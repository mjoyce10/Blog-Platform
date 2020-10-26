﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog_template_practice;

namespace BlogPlatform.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20201025150920_AddImages")]
    partial class AddImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("blog_template_practice.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "DGEvent.jpg",
                            Name = "Event Discussion"
                        },
                        new
                        {
                            Id = 2,
                            Image = "DGBag.jpg",
                            Name = "What's in Your Bag?"
                        },
                        new
                        {
                            Id = 3,
                            Image = "DGTips.jpg",
                            Name = "Tips & Tricks"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("PublishDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "John Smith",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 1,
                            PublishDate = "09/14/20",
                            Title = "2020 MVP Open at Maple Hill"
                        },
                        new
                        {
                            Id = 2,
                            Author = "John Smith",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 1,
                            PublishDate = "10/04/20",
                            Title = "2020 Jonesboro Open"
                        },
                        new
                        {
                            Id = 3,
                            Author = "John Smith",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 1,
                            PublishDate = "10/19/20",
                            Title = "Disc Golf Pro Tour Championship"
                        },
                        new
                        {
                            Id = 4,
                            Author = "John Smith",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 2,
                            PublishDate = "10/15/20",
                            Title = "A Beginner's Bag"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Duke Goldberg",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 2,
                            PublishDate = "10/18/20",
                            Title = "My Must-Have Discs"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Doug Discman",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 2,
                            PublishDate = "10/20/20",
                            Title = "My Bag isn't Big Enough!"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Darlene Discman",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 3,
                            PublishDate = "10/10/20",
                            Title = "Start with a Few Discs"
                        },
                        new
                        {
                            Id = 8,
                            Author = "John Smith",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 3,
                            PublishDate = "10/16/20",
                            Title = "Disc Release - Flat and Low"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Duke Goldberg",
                            Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean et bibendum sem, eu interdum mi. Sed eget elit quis mauris commodo dapibus. Integer mi turpis, commodo quis ligula non, accumsan interdum risus. Vestibulum pharetra nec felis id sollicitudin. Phasellus ex nunc, sollicitudin in semper eget, pulvinar ac nisi. Aenean venenatis velit id neque blandit egestas. Nam id elit nec mauris lacinia venenatis eget non leo. Ut in metus et lorem imperdiet eleifend. Morbi congue odio vel sapien tempus, et elementum nisl vestibulum.",
                            CategoryId = 3,
                            PublishDate = "10/20/20",
                            Title = "Develop a Practice Routine"
                        });
                });

            modelBuilder.Entity("blog_template_practice.Models.Content", b =>
                {
                    b.HasOne("blog_template_practice.Models.Category", "Category")
                        .WithMany("Contents")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
