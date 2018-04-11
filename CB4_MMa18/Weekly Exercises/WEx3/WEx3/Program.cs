using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BlogPost> blogPosts = BlogPostGenerator.GetBlogPosts();

            var query1 = blogPosts.FindPostById("18CF7969-98E0-40C9-9AFF-BE45DEA97E72");
            var query2 = blogPosts.FindPostsContainWord("lacus");
            var qyery3 = blogPosts.FindPostsWithTitleLargerThan(2);
            var query4 = blogPosts.FindPostsByUserWithId("8B332881-16A0-4EA0-B8BE-ED6349F80744");
            var qyery5 = blogPosts.GetAllBlogPostsIds();

            string json = JsonConverter.BlogPostsToJson(blogPosts);
            Console.WriteLine(json);
        }
    }
}
