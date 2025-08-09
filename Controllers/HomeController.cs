using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaDeControleVeiculos.data;
using SistemaDeControleVeiculos.Models;

namespace SistemaDeControleVeiculos.Controllers;

public class HomeController : Controller
{
    private readonly BancoContext _context;

public HomeController(BancoContext context)
    {
        _context = context;
     
    }
    public IActionResult Index()
    {
        var veiculos = _context.Veiculos.ToList();
        return View(veiculos);
    }
  public IActionResult Adicionar()
    {
        return View();
    }
   
   [HttpPost]
    public IActionResult Adicionar(VeiculosModel veiculo)
    {
        if (ModelState.IsValid)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(veiculo);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
