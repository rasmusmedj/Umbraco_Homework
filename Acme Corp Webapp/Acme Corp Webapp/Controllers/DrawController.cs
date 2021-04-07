using Microsoft.AspNetCore.Mvc;
using Acme_Corp_Webapp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Text;

namespace Acme_Corp_Webapp.Controllers
{
    public class DrawController : Controller
    {
        private readonly DrawSubmissionDataContext db;
        private readonly SerialNumberDataContext serialDb;
        public DrawController(DrawSubmissionDataContext db, SerialNumberDataContext serialDb)
        {
            this.db = db;
            this.serialDb = serialDb;
        }

        public IActionResult Index()
        {
            var drawSubmissions = db.DrawSubmissions.ToList();
            return View(drawSubmissions);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Submissions()
        {
            var drawSubmissions = db.DrawSubmissions.ToList();
            return View(drawSubmissions);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DrawSubmission drawSubmission)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!drawSubmission.IsEighteen)
            {
                return RedirectToAction("NotEighteen");
            }

            if (!IsUsedTwice(drawSubmission.SerialNumber))
            {
                return View();
            }

            if (!IsValid(drawSubmission.SerialNumber))
            {
                return View();
            }

            if (IsWinner())
            {
                drawSubmission.IsWinner = true;
                db.DrawSubmissions.Add(drawSubmission);
                db.SaveChanges();

                return RedirectToAction("Winner");
            }
            else
            {
                drawSubmission.IsWinner = false;
                db.DrawSubmissions.Add(drawSubmission);
                db.SaveChanges();

                return RedirectToAction("Loser");
            }            
        }

        public IActionResult Winner()
        {
            return View();
        }

        public IActionResult Loser()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Generator()
        {
            var serialNumbers = serialDb.SerialNumbers.ToList();
            return View(serialNumbers);
        }

        [HttpPost, Authorize(Roles = "Admin")]
        public IActionResult Generator(int amount)
        {
            GenerateSerialNumber(amount);
            var serialNumbers = serialDb.SerialNumbers.ToList();
            return View(serialNumbers);
        }

        public IActionResult Export()
        {
            var cc = new CsvConfiguration(new System.Globalization.CultureInfo("en-US"));
            using (var ms = new MemoryStream())
            {
                using (var sw = new StreamWriter(stream: ms, encoding: new UTF8Encoding(true)))
                {
                    using (var cw = new CsvWriter(sw, cc))
                    {
                        cw.WriteRecords(serialDb.SerialNumbers);
                    }// The stream gets flushed here.
                    return File(ms.ToArray(), "text/csv", $"export_{DateTime.UtcNow.Ticks}.csv");
                }
            }
        }

        public IActionResult NotEighteen()
        {
            return View();
        }

        public bool IsUsedTwice(string serialNumber)
        {
            int counter = 0;
            foreach (var drawSubmission in db.DrawSubmissions)
            {
                if (drawSubmission.SerialNumber == serialNumber)
                {
                    counter++;

                    if (counter > 1)
                    {
                        return false;
                    }
                }                
            }
            return true;
        }

        public bool IsWinner()
        {
            Random randomInt = new Random();
            if (randomInt.Next(1,4) < 3)
            {
                return false;
            }
            return true;
        }

        public void GenerateSerialNumber(int amount)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();            

            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < stringChars.Length; j++)
                {
                    stringChars[j] = chars[random.Next(chars.Length)];
                }
                SerialNumber newSerialNumber = new SerialNumber();
                newSerialNumber.MySerialNumber = new String(stringChars);
                
                serialDb.SerialNumbers.Add(newSerialNumber);
                serialDb.SaveChanges();
            }
        }

        public bool IsValid(string serialNumber)
        {
            foreach (var s in serialDb.SerialNumbers)
            {
                if (serialNumber == s.MySerialNumber)
                {
                    return true;
                }                
            }
            return false;
        }
    }
}
