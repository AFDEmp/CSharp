using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEx3
{
    public static class Queries
    {
        public static BlogPost FindPostById(this List<BlogPost> source, string id)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(nameof(id));
            }

            Guid guid = Guid.Parse(id);
            BlogPost result = null;

            foreach (BlogPost blogPost in source)
            {
                if (blogPost.Id == guid)
                {
                    result = blogPost;
                    break;
                }
            }

            return result;
        }

        public static List<BlogPost> FindPostsContainWord(this List<BlogPost> source, string word)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentException(nameof(word));
            }

            List<BlogPost> result = new List<BlogPost>();

            foreach (BlogPost blogPost in source)
            {
                if (blogPost.Body.Contains(word))
                {
                    result.Add(blogPost);
                }
            }

            return result;
        }

        public static List<BlogPost> FindPostsWithTitleLargerThan(this List<BlogPost> source, int length)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            List<BlogPost> result = new List<BlogPost>();

            foreach (BlogPost blogPost in source)
            {
                int words = blogPost.Title.Split(' ').Length;
                if (words > length)
                {
                    result.Add(blogPost);
                }
            }

            return result;
        }

        public static List<BlogPost> FindPostsByUserWithId(this List<BlogPost> source, string id)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException(nameof(id));
            }

            Guid guid = Guid.Parse(id);
            List<BlogPost> result = new List<BlogPost>();

            foreach (BlogPost blogPost in source)
            {
                if (blogPost.User.Id == guid)
                {
                    result.Add(blogPost);
                }
            }

            return result;
        }

        public static List<Guid> GetAllBlogPostsIds(this List<BlogPost> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            List<Guid> result = new List<Guid>();

            foreach (BlogPost blogPost in source)
            {
                result.Add(blogPost.Id);
            }

            return result;
        }
    }
}
