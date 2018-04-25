using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(string connection) : base(connection)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasKey(i => i.Id);
            modelBuilder.Entity<Blog>().Property(i => i.Title).HasMaxLength(200).HasColumnName("Name");
            modelBuilder.Entity<Blog>().Property(i => i.Url).HasMaxLength(200);

            modelBuilder.Entity<Post>().HasKey(i => i.Id);
            modelBuilder.Entity<Post>().Property(i => i.Title).HasMaxLength(200);
            modelBuilder.Entity<Post>().Property(i => i.DateCreated).IsRequired();
            modelBuilder.Entity<Post>()
                .HasRequired(i => i.Blog)
                .WithMany(i => i.Posts)
                .HasForeignKey(i => i.BlogId)
                .WillCascadeOnDelete(true);
        }
    }
}
