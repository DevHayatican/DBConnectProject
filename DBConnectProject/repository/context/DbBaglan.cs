using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.repository.context
{
    internal class DbBaglan : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("server=CAN;database=Northwind;Trusted_connection=True;TrustServerCertificate=True");
        }

        public DbSet<Customers> Customers { get; set; }

    }

}
