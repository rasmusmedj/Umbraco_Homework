using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme_Corp_Webapp.Models
{
    public class SerialNumberDataContext : DbContext
    {
        public DbSet<SerialNumber> SerialNumbers { get; set; }

        public SerialNumberDataContext(DbContextOptions<SerialNumberDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
