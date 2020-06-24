﻿using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        // GET: Note
        public ActionResult Index()
        {
            var model = new NoteLIstItem[0];
            return View(model);
        }

        //Add method here VVV
        //GET
        public ActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create (NoteCreate model)
        {
            if(ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}