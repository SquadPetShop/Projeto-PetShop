using Microsoft.AspNetCore.Mvc;

namespace Projeto_LojaPet.Controllers
{
    public class ContaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
