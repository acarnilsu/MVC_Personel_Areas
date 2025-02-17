﻿using MVC_Personel_Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_Personal_Project.Controllers
{

    public class DefaultController : Controller
    {
        // GET: Default
        DbistanbulAkademiMvcEntities dbistanbulAkademiMvcEntities = new DbistanbulAkademiMvcEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult BannerPartial()
        {
            return PartialView();
        }

        public PartialViewResult SkillPartial()
        {
            var values = dbistanbulAkademiMvcEntities.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult FeaturePartial()
        {
            return PartialView();
        }

        public PartialViewResult ImagePartial()
        {
            ViewBag.v = "C# ve .Net alanında yaptığım projelerin görsellerine aşağıdan ulaşabilirsiniz.";
            var values = dbistanbulAkademiMvcEntities.TblImage.ToList();
            var categories = dbistanbulAkademiMvcEntities.TblImage.Select(x=>x.Category).Distinct().ToList();
            ViewBag.categories = categories;
            return PartialView(values);
        }

        public PartialViewResult ExperiencePartial()
        {
            return PartialView();
        }

        public PartialViewResult EducationPartial()
        {
            return PartialView();
        }

        public PartialViewResult TestimonialPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}