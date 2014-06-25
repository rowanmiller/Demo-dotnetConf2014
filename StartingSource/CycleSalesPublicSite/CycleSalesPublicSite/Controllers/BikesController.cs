using CycleSalesPublicSite.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace CycleSalesPublicSite.Controllers
{
    public class BikesController : Controller
    {
        private CycleContext db;

        public BikesController()
            : this(new CycleContext())
        { }

        public BikesController(CycleContext context)
        {
            this.db = context;
        }

        public ActionResult Index()
        {
            var query = from b in db.Bikes
                        orderby b.Retail
                        select b;

            return View(query.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bike bike = db.Bikes.Find(id);
            if (bike == null)
            {
                return HttpNotFound();
            }
            return View(bike);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
