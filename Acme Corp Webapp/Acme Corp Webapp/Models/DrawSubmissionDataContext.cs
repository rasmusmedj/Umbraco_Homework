using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Acme_Corp_Webapp.Models
{
    public class DrawSubmissionDataContext : DbContext
    {
        public DbSet<DrawSubmission> DrawSubmissions { get; set; }
        
        public DrawSubmissionDataContext(DbContextOptions<DrawSubmissionDataContext>options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
