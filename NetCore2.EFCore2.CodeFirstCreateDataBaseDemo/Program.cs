using NetCore2.EFCore2.Models;
using System;

namespace NetCore2.EFCore2.CodeFirstCreateDataBaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertTestData();
            Console.Read();
        }


        static void InsertTestData()
        {
            using (var db = new BloggingContext())
            {
                db.Blog.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blog)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                }
            }
        }


    }
}
