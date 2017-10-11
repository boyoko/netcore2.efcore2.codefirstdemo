# netcore2.efcore2.codefirstdemo

# 1、add package

Install-Package Microsoft.EntityFrameworkCore.SqlServer

Install-Package Microsoft.EntityFrameworkCore.Tools

# 2、Create DataBase by PMC (package Package Manager)

 ## add Blog Class
 
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
    }
    
 ## create database

    Add-Migration MyFirstMigration

    Update-Database
    
 ## insert test data
 
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
        

# 3、Add New Class Post then update DataBase

## add Post Class

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
    
## modify BloggingContext , add thus:

  public DbSet<Post> Post { get; set; }
  
## Update DataBase by PMC

  Add-Migration AddPost
  
  Update-Database

# 4、Add a field to class Blog ,then update database

  ## add a field
  
  public DateTime CreateTime { get; set; }
  
  ## update database
  
  Add-Migration updatedb
  
  Update-Database updatedb
  
  

