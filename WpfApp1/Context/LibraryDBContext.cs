using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Configuration;
using WpfApp1.Models;

namespace WpfApp1.Context
{
    public class LibraryDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0128-15;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new FacultiesConfiguration());
            modelBuilder.ApplyConfiguration(new LibConfiguration());
            modelBuilder.ApplyConfiguration(new PressConfiguration());
            modelBuilder.ApplyConfiguration(new S_cardsConfiguration());
            modelBuilder.ApplyConfiguration(new StudentsConfiguration());
            modelBuilder.ApplyConfiguration(new T_CardsConfiguration());
            modelBuilder.ApplyConfiguration(new TeachersConfiguration());
            modelBuilder.ApplyConfiguration(new ThemeConfiguration());
        }



        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<Category> Categories { get; set; }
        public List<Department> Departments { get; set; }
        public List<Faculty> Faculties { get; set; }
        public List<Group> Groups { get; set; }
        public List<Lib> Libs { get; set; }
        public List<Press> Presses { get; set; }
        public List<S_Card> S_Cards { get; set; }
        public List<Student> Students { get; set; }
        public List<T_Card> T_Cards { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Theme> Themes { get; set; }

    }
}
