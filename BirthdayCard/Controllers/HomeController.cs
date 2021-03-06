﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BirthdayCard.Models;

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SendCard()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendCard(SendCard sendCard)
        {
            if (ModelState.IsValid)
            {
                return View("Sent", sendCard);
            }
            return View();
        }
    }
}