using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApplication.Data
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}