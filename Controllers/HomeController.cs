using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using simulacro_vite.Models;
using Microsoft.EntityFrameworkCore;

namespace simulacro_vite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CompraContext _context;

        public HomeController(ILogger<HomeController> logger, CompraContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // SELECT * FROM name_table;
            var solicitudes = _context.SolicitudesCompra.Include(s => s.Usuario).ToList();
            // Lo enviamos a la vista
            return View(solicitudes);
        }

        public IActionResult SolicitudCompra()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SolicitudCompra(SolicitudCompra solicitud)
        {
            if (ModelState.IsValid)
            {
                // Guardar el objeto y hacer una redireccion
                var usuario = _context.Usuarios.First(s => s.Id == 1);
                solicitud.Usuario  = usuario;
                _context.Add(solicitud);
                _context.SaveChanges();

                return RedirectToAction("Index");
                
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class SolicitudCompra
    {
        public Producto Producto { get; internal set; }
        public Usuario Usuario { get; internal set; }
    }
}
