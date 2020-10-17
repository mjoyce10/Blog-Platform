using blog_template_practice.Controllers;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace blog_template_practice.Tests
{
    public class ContentControllerTests
    {
        ContentController sut;
        IRepository<Content> contentRepo;

        public ContentControllerTests()
        {
            contentRepo = Substitute.For<IRepository<Content>>();
            sut = new ContentController(contentRepo);
        }

        [Fact]
        public void Index_Returns_A_ViewResult()
        {
            //var result = sut.Index();

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Contents_To_View()
        {
            //var expectedContents = new List<Content>();
            //contentRepo.GetAll().Returns(expectedContents);

            //var result = sut.Index();

            //Assert.Equal(expectedContents, result.Model);
        }

        [Fact]
        public void Details_Returns_A_ViewResult()
        {
            //var result = sut.Details(1);

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Content_To_View()
        {
            //var expectedContent = new Content();
            //contentRepo.GetById(1).Returns(expectedContent);

            //var result = sut.Details(1);

            //Assert.Equal(expectedContent, result.Model);
        }

        [Fact]
        public void Create_Returns_a_ViewResult()
        {
            //var result = sut.Create();

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void CreateByCategoryId_Returns_A_ViewResult()
        {
            //var result = sut.CreateByCategoryId(1);

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Create_Post_Returns_ActionResult()
        {
            //var result = sut.Create(new Content());

            //Assert.IsAssignableFrom<ActionResult>(result);
        }

        [Fact]
        public void Update_Returns_ViewResult()
        {
            //var result = sut.Update(1);

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Update_Passes_Content_To_View()
        {
            //var expectedContent = new Content();
            //contentRepo.GetById(1).Returns(expectedContent);

            //var result = sut.Update(1);

            //Assert.Equal(expectedContent, result.Model);
        }

        [Fact]
        public void Update_Post_Returns_ActionResult()
        {
            //var result = sut.Update(new Content());

            //Assert.IsAssignableFrom<ActionResult>(result);
        }

        [Fact]
        public void Delete_Returns_ViewResult()
        {
            //var result = sut.Delete(1);

            //Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Delete_Passes_Content_To_View()
        {
            //var expectedContent = new Content();
            //contentRepo.GetById(1).Returns(expectedContent);

            //var result = sut.Delete(1);

            //Assert.Equal(expectedContent, result.Model);
        }

        [Fact]
        public void Delete_Post_Returns_ActionResult()
        {
            //var result = sut.Delete(new Content());

            //Assert.IsAssignableFrom<ActionResult>(result);
        }

    }
}
