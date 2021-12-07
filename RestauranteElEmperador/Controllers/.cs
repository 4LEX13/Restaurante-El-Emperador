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

            
            cliente.NombreCliente = "kevin";
            cliente.ApellidoCliente = "Navarro";
            cliente.DireccionCliente = "chalatenango";
            cliente.TelefonoCliente = 785287912;
            icliente.insertar(cliente);


            return View();
        }


        public IActionResult GetAll()
        {
            var DandoFormatoJson = icliente.listarcliente();

            return Json(new { Data = DandoFormatoJson });
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
