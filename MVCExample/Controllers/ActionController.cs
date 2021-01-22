using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class ActionController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View(new ActionModel());
        }
    }
}