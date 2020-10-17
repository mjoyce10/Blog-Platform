using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Controllers
{
    public class CategoryController : Controller
    {
        IRepository<Category> categoryRepo;

        public CategoryController(IRepository<Category> categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }

    }
}
