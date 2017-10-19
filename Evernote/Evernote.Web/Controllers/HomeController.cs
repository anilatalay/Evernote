using Evernote.BusinessLayer;
using Evernote.Entities;
using Evernote.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Evernote.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // CategoryController üzerinden gelen view talebi ve model..
            //if (TempData["nm"] != null)
            //{
            //    return View(TempData["nm"] as List<DNote>);
            //}

            NoteManager nm = new NoteManager();
            return View(nm.GetAllNote().OrderByDescending(x => x.ModifiedOn).ToList());
            // return View(nm.GetAllNoteQueryable().OrderByDescending(x => x.ModifiedOn).ToList());
        }

        public ActionResult ByCategory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CategoryManager cm = new CategoryManager();
            var cat = cm.GetDCategoryById(id.Value);

            if (cat == null)
            {
                return HttpNotFound();
                // return RedirectToAction("Index", "Home");
            }

            //TempData["nm"] = cat.Notes;
            //return RedirectToAction("Index", "Home");
            return View("Index", cat.Notes.OrderByDescending(x => x.ModifiedOn).ToList());
        }

        public ActionResult MostLiked()
        {
            NoteManager nm = new NoteManager();
            return View("Index", nm.GetAllNote().OrderByDescending(x => x.LikeCount).ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserManager um = new UserManager();
                var res = um.RegisterUser(model);
                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(x => ModelState.AddModelError("", x));
                    return View(model);
                }

                return RedirectToAction("RegisterOk");
            }
            return View(model);
        }

        public ActionResult UserActive(Guid active_id)
        {
            return View();
        }

        public ActionResult Test()
        {
            return null;
        }

        public ActionResult RegisterOk()
        {
            return View();
        }
    }
}