using Microsoft.AspNetCore.Mvc;

namespace Mvc.Formatters.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        // POST home/echo
        [HttpPost]
        public string Echo([FromBody]string value)
        {
            return value;
        }
    }
}
