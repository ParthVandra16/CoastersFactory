using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CoastersFactory.Models;

// create databse context class

namespace CoastersFactory.Data
{
    public class CoastersFactoryContext : IdentityDbContext
    {
        public CoastersFactoryContext(DbContextOptions<CoastersFactoryContext> options)
            : base(options)
        {
        }
        public DbSet<CoastersFactory.Models.Coasters> Coasters { get; set; }
    }
}
