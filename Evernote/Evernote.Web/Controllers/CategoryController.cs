using System.Web.Mvc;
using System.Net;
using Evernote.BusinessLayer;

namespace Evernote.Web.Controllers
{
    public class CategoryController : Controller
    {
        // GET: TempData ile Category Listeleme..
        //public ActionResult Select(int? id)
        //{
        //    if(id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    CategoryManager cm = new CategoryManager();
        //    var cat = cm.GetDCategoryById(id.Value);

        //    if(cat == null)
        //    {
        //        return HttpNotFound();
        //        // return RedirectToAction("Index", "Home");
        //    }

        //    TempData["nm"] = cat.Notes;
        //    return RedirectToAction("Index", "Home");
        //}
    }
}