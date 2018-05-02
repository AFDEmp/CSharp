using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BlogApplication.Data
{
    public class BlogsRepository : IBlogsRepository
    {
        public List<Blog> GetAllBlogs()
        {
            using (BlogDbContext db = new BlogDbContext())
            {
                return db.Blogs.ToList();
            }
        }
        public Blog FindBlogById(int id)
        {
            using (BlogDbContext db = new BlogDbContext())
            {
                return db.Blogs.SingleOrDefault(i => i.Id == id);
            }
        }

        public void UpdateBlog(Blog blog)
        {
            using (BlogDbContext db = new BlogDbContext())
            {
                db.Blogs.Attach(blog);
                db.Entry(blog).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void CreateBlog(Blog blog)
        {
            if(blog == null)
            {
                throw new ArgumentNullException("blog");
            }

            using (BlogDbContext db = new BlogDbContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }
    }
}
