using System;

namespace WEx3
{
    public class BlogPost
    {
        /// <summary>
        /// Blog post id.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// User wrote the blog post.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Title of the blog post.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Body of the blog post.
        /// </summary>
        public string Body { get; set; }
    }
}
