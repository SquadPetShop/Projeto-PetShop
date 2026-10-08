using Microsoft.AspNetCore.Mvc;
using Projeto_LojaPet.Models;
using System.Diagnostics;

namespace Projeto_LojaPet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clientes()
        {
            var clientes = Simulacao.ClientesList;
            return View(clientes);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
