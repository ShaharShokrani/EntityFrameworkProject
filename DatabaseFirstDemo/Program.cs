using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDbContext();
            var courses = context.GetCourses();
            foreach (var item in courses)
            {
                Console.WriteLine(item.Description);
            }

            //var context = new DatabaseFirstDemoEntities();
            //var post = new Post()
            //{
            //    Body = "Body",
            //    DatePublished = DateTime.UtcNow,
            //    Title = "Title",
            //    PostID = 1
            //};

            //context.Posts.Add(post);
            //context.SaveChanges();
        }
    }
}
