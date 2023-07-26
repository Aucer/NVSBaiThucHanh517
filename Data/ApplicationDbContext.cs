using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWeb.Models;
using FirstWeb.Data;
namespace FirstWeb.Data;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FirstWeb.Models.Student> Student { get; set; } = default!;

        public DbSet<FirstWeb.Models.Person> Person { get; set; } = default!;

        public DbSet<FirstWeb.Models.Animal> Animal { get; set; } = default!;

        public DbSet<FirstWeb.Models.Dog> Dog { get; set; } = default!;

        public DbSet<FirstWeb.Models.Cat> Cat { get; set; } = default!;

        public DbSet<FirstWeb.Models.Employee> Employee { get; set; } = default!;
        public DbSet<FirstWeb.Models.Faculty> Faculty { get; set; } = default!;
    }
