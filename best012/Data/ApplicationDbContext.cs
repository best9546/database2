using System;
using System.Collections.Generic;
using System.Text;
using best012.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace best012.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
