using Microsoft.AspNetCore.Mvc;
using Shop;
namespace EStoreWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]  // link - http://localhost:port/api/Products
//[Route("[controller]")]  // link - http://localhost:port/Products

public class ProductsController : ControllerBase
{

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }


    [HttpGet]
    // link - http://localhost:port/api/Products
    // request type get 
    public IEnumerable<Product> GetAllData()
    {

        List<Product> list = new List<Product>();
        list.Add(new Product { Pname = "Table", Category = "Furniture", Price = 5000 });
        list.Add(new Product { Pname = "Chair", Category = "Furniture", Price = 1000 });
        list.Add(new Product { Pname = "Bed", Category = "Furniture", Price = 10000 });
        list.Add(new Product { Pname = "SSD", Category = "Computer", Price = 3400 });
        list.Add(new Product { Pname = "RAM", Category = "Computer", Price = 8000 });
        return list;
    }




}
