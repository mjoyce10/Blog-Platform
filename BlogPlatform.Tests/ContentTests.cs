using blog_template_practice.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace blog_template_practice.Tests
{
    public class ContentTests
    {
        Content sut;

        public ContentTests()
        {
            sut = new Content(1, "Content title", "This is the body of the blog content", "Blog author name", "10/13/2020");
        }

        [Fact]
        public void ContentContructor_Should_Set_Id()
        {
            int result = sut.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void ContentConstructor_Should_Set_Title()
        {
            string result = sut.Title;

            Assert.Equal("Content title", result);
        }

        [Fact]
        public void ContentConstructor_Should_Set_Body()
        {
            string result = sut.Body;

            Assert.Equal("This is the body of the blog content", result);
        }

        [Fact]
        public void ContentConstructor_Should_Set_Author()
        {
            string result = sut.Author;

            Assert.Equal("Blog author name", result);
        }

        [Fact]
        public void ContentConstructor_Should_Set_PublishDate()
        {
            string result = sut.PublishDate;

            Assert.Equal("10/13/2020", result);
        }

    }
}
