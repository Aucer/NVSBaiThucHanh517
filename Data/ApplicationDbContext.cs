using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWeb.Models;
namespace FirstWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; } = default!;
        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Animals> Animals { get; set; } = default!;
        public DbSet<FirstWeb.Models.Dog> Dog { get; set; } = default!;
        public DbSet<FirstWeb.Models.Cat> Cat { get; set; } = default!;
    }
}
