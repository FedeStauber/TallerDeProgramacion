using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP_Final.Domain;

namespace TP_Final.DAL.EntityFramework
{
    class LibraryManagerDbContext : DbContext
    {
        /// <summary>
        /// Se configura la string connection para la db obteniendo los valores del app.config
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                $"Server={ConfigurationManager.AppSettings.Get("db_server")};" +
                $"Port={ConfigurationManager.AppSettings.Get("db_port")};" +
                $"User Id={ConfigurationManager.AppSettings.Get("db_user")};" +
                $"Password={ConfigurationManager.AppSettings.Get("db_password")};" +
                $"Database={ConfigurationManager.AppSettings.Get("db_name")}"
                );
            base.OnConfiguring(optionsBuilder);
        }
        /// <summary>
        /// Por limitaciones de los data annotation que posee la version de EF core,
        /// utilizamos fluent api para determinar las claves unicas de las distintas entidades.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(b => b.DNI).IsUnique();
            modelBuilder.Entity<User>().HasIndex(b => b.Email).IsUnique();
            modelBuilder.Entity<Book>().HasIndex(b => b.ISBN).IsUnique();
        }
    public LibraryManagerDbContext() : base() {}
       
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
