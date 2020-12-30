using System;
using System.Collections.Generic;
using System.Text;
using gaana.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace gaana.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }   

        public DbSet<Event> Events { get; set;  }
        public DbSet<Book> Books { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
