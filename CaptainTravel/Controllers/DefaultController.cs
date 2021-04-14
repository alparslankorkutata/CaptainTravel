using System.Linq;
using System.Web.Mvc;
using CaptainTravel.Models.Siniflar;
namespace CaptainTravel.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.Take(10).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID >= 51).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 35).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var degers = c.Blogs.Take(10).ToList();
            return PartialView(degers);
        }
        public PartialViewResult Partial4()
        {
            var degerlers = c.Blogs.Take(3).ToList();
            return PartialView(degerlers);
        }
        public PartialViewResult Partial5()
        {
            var degerlerss = c.Blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(degerlerss);
        }
    }
}