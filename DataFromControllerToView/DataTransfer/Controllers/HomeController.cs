using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DataTransfer.Models;
using System.Collections.Generic;
namespace DataTransfer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult ProductsList()
    {
// populated list is received from static method
List<Products> list = Products.GetProducts();
ViewData["catelog"]= list;  // it is send to view - ProductList.cshtml via object
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
