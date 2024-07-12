using Microsoft.AspNetCore.Mvc;

namespace Projeto_ArqueoList.Controllers.API
{
    public class APIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
