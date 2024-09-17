using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChurrascOli.Data;
using ChurrascOli.Models;
using Microsoft.EntityFrameworkCore;
using ChurrascOli.ViewModels;

namespace ChurrascOli.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Tipos = _context.Tipos.ToList(),
            Churrascos = _context.Churrascos
                .Include(p => p.Tipo)
                .ToList()
        };
        return View(home);
    }

    [HttpGet]
    public IActionResult Details(int id)
    {
        Churrasco pokemon = _context.Churrascos
            //.Where(p => p.Numero == id)
            .Include(p => p.TipoId)
            .ThenInclude(pt => pt.Tipo)
            .SingleOrDefault();
        DetailsVM details = new()
        {
            Atual = Churrasco,
        };
        return View(churrasco);
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
