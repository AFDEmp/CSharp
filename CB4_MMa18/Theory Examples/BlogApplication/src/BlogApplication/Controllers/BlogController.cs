using BlogApplication.Data;
using BlogApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            using (BlogDbContext db = new BlogDbContext("BlogDb"))
            {
                return View(db.Blogs.ToList());
            }      
        }

        public ActionResult FindBlog(int id)
        {
            return View(BlogsList.GetAllBlogs().Find(i => i.Id == id));
        }
    }
}