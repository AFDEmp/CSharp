using System;
using System.Collections.Generic;
using System.Text;

namespace WEx3
{
    public static class JsonConverter
    {
        public static string BlogPostsToJson(List<BlogPost> blogPosts)
        {
            if (blogPosts == null)
            {
                throw new ArgumentNullException(nameof(blogPosts));
            }

            StringBuilder json = new StringBuilder();
            json.Append("[");

            foreach (BlogPost blogPost in blogPosts)
            {
                json.Append("{");
                json.Append($"\"{nameof(BlogPost.Id)}\":\"{blogPost.Id}\",");
                json.Append($"\"{nameof(BlogPost.Title)}\":\"{blogPost.Title}\",");
                json.Append($"\"{nameof(BlogPost.Body)}\":\"{blogPost.Body}\",");
                json.Append($"\"{nameof(BlogPost.User)}\":");
                json.Append("{");
                json.Append($"\"{nameof(User.Id)}\":\"{blogPost.User.Id}\",");
                json.Append($"\"{nameof(User.Username)}\":\"{blogPost.User.Username}\"");
                json.Append("}");
                json.Append("},");
            }

            json.Remove(json.Length - 1, 1);
            json.Append("]");

            return json.ToString();
        }
    }
}
