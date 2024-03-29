﻿using KaemeWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace KaemeWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {   
        }

        public DbSet<Cliente> Cliente { get; set; }        
        public DbSet<FreteStatus> FreteStatus { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }


    }
}