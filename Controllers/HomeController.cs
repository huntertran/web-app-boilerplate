using Microsoft.AspNetCore.Mvc;

namespace WebAppBoilerplate.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Ok(new
            {
                message = "Hello World!"
            });
        }
    }
}
