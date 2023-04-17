using System.Diagnostics;
using ApplicationCore.Entities;
using ApplicationCore.Model;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly EmployeeRepository _repository;
    public HomeController(ILogger<HomeController> logger, EmployeeRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public IActionResult Index()
    {
        ViewBag.AnyValue = "This is an item stored in viewbag";
       IEnumerable<Employees> listemp = _repository.GetAll();
        return View(listemp);
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
