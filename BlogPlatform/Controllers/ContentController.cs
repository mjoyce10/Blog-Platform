﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }

        public ViewResult Index()
        {
            var model = contentRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = contentRepo.GetById(id);
            return View(model);
        }
    }
}
