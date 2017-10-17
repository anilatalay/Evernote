using Evernote.BusinessLayer;
using Evernote.Entities;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace Evernote.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // CategoryController üzerinden gelen view talebi ve model..
            //if (TempData["nm"] != null)
            //{
            //    return View(TempData["nm"] as List<DNote>);
            //}

            NoteManager nm = new NoteManager();
            return View(nm.GetAllNote());
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
            return View("Index", cat.Notes);
        }
    }
}