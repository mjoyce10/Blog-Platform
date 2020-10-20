using blog_template_practice.Controllers;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace blog_template_practice.Tests
{
    public class CategoryControllerTests
    {
        CategoryController sut;
        IRepository<Category> categoryRepo;

        public CategoryControllerTests()
        {
            categoryRepo = Substitute.For<IRepository<Category>>();
            sut = new CategoryController(categoryRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Categories_To_View()
        {
            var expectedCategories = new List<Category>();
            categoryRepo.GetAll().Returns(expectedCategories);

            var result = sut.Index();

            Assert.Equal(expectedCategories, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = sut.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Category_To_View()
        {
            var expectedCategory = new Category();
            categoryRepo.GetById(1).Returns(expectedCategory);

            var result = sut.Details(1);

            Assert.Equal(expectedCategory, result.Model);
        }
    }
}
