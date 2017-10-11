using Evernote.BusinessLayer;
using System.Web.Mvc;

namespace Evernote.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Test test = new Test();
            test.InsertTest();

            return View();
        }
    }
}