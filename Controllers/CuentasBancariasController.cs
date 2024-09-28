using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC2MKTS.Data;
using PC2MKTS.Models;
using PC2MKTS.ViewModel;

namespace PC2MKTS.Controllers
{
    public class CuentasBancariasController : Controller
    {
        private readonly ILogger<CuentasBancariasController> _logger;
        private readonly ApplicationDbContext _context;

        public CuentasBancariasController(ILogger<CuentasBancariasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

       public IActionResult Index()
{
    var viewModel = new CuentasBancariasViewModel
    {
        // Si es necesario, puedes inicializar propiedades del ViewModel aquí.
    };
    
    return View(viewModel); // Pasa el ViewModel a la vista
}

[HttpPost]
public IActionResult Registrar(CuentasBancariasViewModel viewModel)
{
    var bancos = new Bancos
    {
        nomTit = viewModel.FormCuentasBancarias.nomTit,
        tipCuen = viewModel.FormCuentasBancarias.tipCuen,
        salIni = viewModel.FormCuentasBancarias.salIni,
        correO = viewModel.FormCuentasBancarias.correO,

    };
      _context.DataBancos.Add(bancos);
            _context.SaveChanges();

            ViewData["Message"] = "Cuenta Bancaria registrada con exito";

            return View("Index", viewModel);
}

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
public IActionResult Error()
{
    return View("Error");
}

    }
}