using BlogApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        private readonly IBlogsRepository _repository = new BlogsRepository();

        // GET: Blog
        public ActionResult Index()
        {
            return View(_repository.GetAllBlogs());
        }

        public ActionResult FindBlog(int id)
        {
            return View(_repository.FindBlogById(id));
        }

        
        public ActionResult Edit(int id)
        {
            return View(_repository.FindBlogById(id));
        }

        [HttpPost]
        public ActionResult Edit(Blog blog)
        {
            _repository.UpdateBlog(blog);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            _repository.CreateBlog(blog);
            return RedirectToAction("Index");
        }
    }
}