namespace MvcMemoryMonitoring.Controllers
{
    using System.Web.Mvc;

    public class MonitorController : Controller
    {
        public ActionResult Memory()
        {
            return View();
        }

        public ActionResult PerfCounters()
        {
            return View();
        }
    }
}
