using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TareaSem7.Models;

namespace TareaSem7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formulario(Formulario formulario)
        {
            if (ModelState.IsValid)
            {
                // TODO: Hacer algo con los parámetros nombre y correo
                return RedirectToAction("FormularioConfirmacion");
            }
            
            return View(formulario);
        }

        public IActionResult FormularioConfirmacion()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
