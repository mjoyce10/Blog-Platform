using blog_template_practice.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace blog_template_practice.Tests
{
    public class CategoryTests
    {
        Category sut;

        public CategoryTests()
        {
            sut = new Category();
        }

        [Fact]
        public void CategoryContructor_Should_Set_Id()
        {
            //int result = sut.Id;

            //Assert.Equal(1, result);
        }

        [Fact]
        public void CategoryConstructor_Should_Set_Name()
        {
            //string result = sut.Name;

            //Assert.Equal("Category name", result);
        }
    }
}
