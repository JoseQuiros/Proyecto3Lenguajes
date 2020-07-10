using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EjemploMVC.Controllers
{
    public class AdministrativoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PaginaPrincipal()
        {
            return View();
        }
        public IActionResult MiEstablecimiento()
        {
            return View();
        }
        public IActionResult Resumenes()
        {
            return View();
        }

    }
}