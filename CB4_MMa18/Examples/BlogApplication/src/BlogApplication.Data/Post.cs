using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApplication.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
