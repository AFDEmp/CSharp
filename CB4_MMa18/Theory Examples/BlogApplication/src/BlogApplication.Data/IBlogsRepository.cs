using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Data
{
    public interface IBlogsRepository
    {
        List<Blog> GetAllBlogs();
        Blog FindBlogById(int id);
        void UpdateBlog(Blog blog);
        void CreateBlog(Blog blog);
    }
}
