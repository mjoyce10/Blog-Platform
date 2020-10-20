using blog_template_practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_templatetest;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Category1"
                },

                new Category
                {
                    Id = 2,
                    Name = "Category2"
                },

                new Category
                {
                    Id = 3,
                    Name = "Category3"
                }
                ); ; ;

            modelBuilder.Entity<Content>().HasData(
                new Content
                {
                    Id = 1,
                    Title = "Title1",
                    Author = "Author1",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "01/01/01",
                    CategoryId = 1
                },

                new Content
                {
                    Id = 2,
                    Title = "Title2",
                    Author = "Author2",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "01/01/01",
                    CategoryId = 2
                },

                new Content
                {
                    Id = 3,
                    Title = "Title3",
                    Author = "Author3",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "01/01/01",
                    CategoryId = 2
                }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
