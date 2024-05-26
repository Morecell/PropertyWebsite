﻿using PropertyWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace PropertyWebsite.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
