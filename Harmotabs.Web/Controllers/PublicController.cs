using System.Linq;
using System.Web.Mvc;
using Harmotabs.Web.Models;

namespace Harmotabs.Web.Controllers
{
    public class PublicController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new HarmotabsContext())
            {
                var topTabs = db.Tablatures.OrderByDescending(x => x.ViewCount).Take(10);
                return View(topTabs);
            }
        }
    }
}