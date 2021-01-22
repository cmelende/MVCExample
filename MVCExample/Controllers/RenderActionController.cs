using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class RenderActionController : Controller
    {
        public ActionResult Index()
        {
            return View(new RenderActionModel());
        }
    }
}