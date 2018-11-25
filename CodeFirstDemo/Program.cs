using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public short FullPrice { get; set; }
        public virtual Author Author { get; set; }
        public virtual IList<Tag> Tags { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Course> Courses { get; set; }
    }

    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Course> Courses { get; set; }
    }

    public enum CourseLevel
    {
        Begginer = 1,
        Intermediate = 2,
        Advanced = 3
    };

    public class PlutoDbContext : DbContext
    {
        public PlutoDbContext() : base("name=PlutoCodeFirstDbContext")
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
