using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStore.Models;
using BLL;
using BOL;
namespace EStore.Controllers;

public class VehicleController : Controller
{
    private readonly ILogger<VehicleController> _logger;

    public VehicleController(ILogger<VehicleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
       List<Vehicle> vehicleList = VehicleManager.GetVehicleDetails();
       ViewData["vehicles"]=vehicleList;
        return View();
    }

    public IActionResult Details(int VehicleId)
    {
    Vehicle vehicle = VehicleManager.GetVehicleDetailsById(VehicleId);
       ViewData["vehicleData"]=vehicle;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
