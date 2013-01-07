namespace MvcMemoryMonitoring.Controllers
{
    using System.Web;
    using System.Web.Mvc;

    public class MonitorController : Controller
    {
        public ActionResult Memory()
        {            
            var res = HttpRuntime.Cache.EffectivePrivateBytesLimit;
            
            return View();
        }

        public ActionResult PerfCounters()
        {
            return View();
        }        
    }
}
