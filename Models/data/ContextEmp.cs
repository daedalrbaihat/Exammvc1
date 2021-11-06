using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Exam2.Models.data
{
    public class ContextEmp : DbContext
    {
        IConfiguration configuration;
        public ContextEmp(IConfiguration _configuration)
        {
            configuration = _configuration;

        }
        public DbSet<Employees> emp { set; get; }
            public DbSet<Country> countries { set; get; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                optionsBuilder.UseSqlServer("data source = localhost ; initial catalog = Exam2; Integrated Security = true");
                base.OnConfiguring(optionsBuilder);
            }








        
    }
}
