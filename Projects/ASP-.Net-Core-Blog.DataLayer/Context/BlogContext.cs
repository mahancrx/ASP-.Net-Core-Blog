using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP_.Net_Core_Blog.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_.Net_Core_Blog.DataLayer.Context
{
    public class BlogContext:DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
