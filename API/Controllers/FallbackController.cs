using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FallbackController : Controller
    {
        private IWebHostEnvironment _env;
        public FallbackController(IWebHostEnvironment env)
        {
            _env = env;
            
        }
        public ActionResult Index()
        {
            return PhysicalFile(Path.Combine(_env.WebRootPath, "index.html"), "text/HTML");
        }
    }
}