using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VisitorManagement.Models;

namespace VisitorManagement.Data
{
    public class VisitorDbContext : DbContext
    {

        // Add in Tables we are using   
        public DbSet<StaffNames> StaffNames { get; set; }
        public DbSet<Visitors> Visitors { get; set; }

        public VisitorDbContext(DbContextOptions<VisitorDbContext> options)
            : base(options)
        {
        }

        public VisitorDbContext()
        {

        }
    }
}
