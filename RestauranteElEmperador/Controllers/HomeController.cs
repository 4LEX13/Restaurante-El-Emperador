using Microsoft.AspNetCore.Mvc;
using RestauranteElEmperador.Services;
using Microsoft.Extensions.Logging;
using RestauranteElEmperador.Models;
using RestauranteElEmperador.Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestauranteElEmperador.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICliente icliente;

        public HomeController(ILogger<HomeController> logger, ICliente icliente)
        {
            this.icliente = icliente;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Cliente cliente = new Cliente();



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
