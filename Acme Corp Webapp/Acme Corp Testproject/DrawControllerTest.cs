using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Acme_Corp_Webapp;
using Acme_Corp_Webapp.Controllers;
using Acme_Corp_Webapp.Models;
using Microsoft.EntityFrameworkCore;

namespace Acme_Corp_Testproject
{
    [TestClass]
    public class DrawControllerTest
    {
        //I am unable to make my tests work. 
        //I think it's because i'm using an Entity Framework database, but i'm not sure.
        //The error message is displayed below
        //"Unable to get default constructor for class Acme_Corp_Testproject.DrawControllerTest"
        //I've had to do manual testing instead
        private readonly DrawSubmissionDataContext db;
        private readonly SerialNumberDataContext serialDb;

        public DrawControllerTest(DrawSubmissionDataContext db, SerialNumberDataContext serialDb)
        {
            this.db = db;
            this.serialDb = serialDb;
        }

        [TestMethod]
        public void Index() //Unable to get default ctor
        {
            
            //arrange
            DrawController drawController = new DrawController(db, serialDb);
            //act
            ViewResult result = drawController.Index() as ViewResult;
            //assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create() 
        {

            //arrange
            DrawController drawController = new DrawController(db, serialDb);
            //act
            ViewResult result = drawController.Create() as ViewResult;
            //assert
            Assert.IsNotNull(result);
        }
    }
}
