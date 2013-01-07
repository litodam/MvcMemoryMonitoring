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

        [OutputCache(Duration = 3000, VaryByParam="*")]
        public ActionResult PerfCounters()
        {
            return View();
        }
        
        public ActionResult OutputCache()
        {
            return View();
        }
    }
}
