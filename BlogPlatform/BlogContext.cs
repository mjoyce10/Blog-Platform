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
                    Name = "Event Discussion"
                },

                new Category
                {
                    Id = 2,
                    Name = "What's in Your Bag?"
                },

                new Category
                {
                    Id = 3,
                    Name = "Tips & Tricks"
                }
                ); ; ;

            modelBuilder.Entity<Content>().HasData(
                new Content
                {
                    Id = 1,
                    Title = "2020 MVP Open at Maple Hill",
                    Author = "John Smith",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "09/14/20",
                    CategoryId = 1
                },

                new Content
                {
                    Id = 2,
                    Title = "2020 Jonesboro Open",
                    Author = "John Smith",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/04/20",
                    CategoryId = 1
                },

                new Content
                {
                    Id = 3,
                    Title = "Disc Golf Pro Tour Championship",
                    Author = "John Smith",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/19/20",
                    CategoryId = 1
                },
                new Content
                {
                    Id = 4,
                    Title = "A Beginner's Bag",
                    Author = "John Smith",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/15/20",
                    CategoryId = 2
                },

                new Content
                {
                    Id = 5,
                    Title = "My Must-Have Discs",
                    Author = "Duke Goldberg",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/18/20",
                    CategoryId = 2
                },

                new Content
                {
                    Id = 6,
                    Title = "My Bag isn't Big Enough!",
                    Author = "Doug Discman",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/20/20",
                    CategoryId = 2
                },

                new Content
                {
                    Id = 7,
                    Title = "Start with a Few Discs",
                    Author = "Darlene Discman",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/10/20",
                    CategoryId = 3
                },

                new Content
                {
                    Id = 8,
                    Title = "Disc Release - Flat and Low",
                    Author = "John Smith",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/16/20",
                    CategoryId = 3
                },

                new Content
                {
                    Id = 9,
                    Title = "Develop a Practice Routine",
                    Author = "Duke Goldberg",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                    PublishDate = "10/20/20",
                    CategoryId = 3
                }
               );

            base.OnModelCreating(modelBuilder);
        }
    }
}
