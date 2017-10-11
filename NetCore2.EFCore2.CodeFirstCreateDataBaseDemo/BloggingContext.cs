using Microsoft.EntityFrameworkCore;
using NetCore2.EFCore2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2.EFCore2.CodeFirstCreateDataBaseDemo
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.ConsoleApp.NewDb;Trusted_Connection=True;");
        }
    }
}
