using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Projeto realizado em sala de aula!!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contato";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
