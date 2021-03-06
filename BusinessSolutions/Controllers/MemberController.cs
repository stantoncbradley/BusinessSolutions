﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessSolutions.Models;

namespace BusinessSolutions.Controllers
{
    public class MemberController : Controller
    {
        //
        //  GET: /Account/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(SignInModel model)
        {
            bool isValid = IsValidUser(model);
            if (!isValid)
            {
                ModelState.AddModelError("", "Your username or password is invalid");
                return View(model);
            }
            else if (model.UserName == "Admin") // is admin
                return RedirectToAction("Index", "Admin");
            else
                return RedirectToAction("Index", "Member");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Index", "Member");

            return View(model);
        }

        private bool IsValidUser(SignInModel model)
        {
            // DATABASE WOULD DO THIS NORMALLY
            if ((model.UserName == "Cole" || model.UserName == "Admin") && model.Password == "password")
                return true;
            return false;
        }
    }
}