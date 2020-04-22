using System;
using Microsoft.EntityFrameworkCore;

namespace mydockerapi.Models{
    public class ApiDbContent : DbContext
    {
        public ApiDbContent(DbContextOptions<ApiDbContent> options)
        :base(options){}

        public DbSet<Blog> Blogs {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new BlogMap(modelBuilder.Entity<Blog>());
        }
    }
}
