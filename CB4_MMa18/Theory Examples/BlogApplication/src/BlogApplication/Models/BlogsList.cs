using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApplication.Models
{
    public static class BlogsList
    {
        public static List<Blog> GetAllBlogs()
        {
            return new List<Blog>
            {
                new Blog
                {
                    Id = 1,
                    Title = "The Visual Studio Blog",
                    Url ="http://blogs.msdn.com/visualstudio/"
                },
                new Blog
                {
                    Id = 2,
                    Title = ".NET Framework Blog",
                    Url = "http://blogs.msdn.com/dotnet/"
                }
            };
        }
    }
}