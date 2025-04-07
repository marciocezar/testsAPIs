using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ScalarAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 1299.99m, Category = "Electronics" },
        new Product { Id = 2, Name = "Smartphone", Price = 799.99m, Category = "Electronics" },
        new Product { Id = 3, Name = "Coffee Maker", Price = 89.99m, Category = "Home Appliances" },
        new Product { Id = 4, Name = "Headphones", Price = 199.99m, Category = "Electronics" },
        new Product { Id = 5, Name = "Toaster", Price = 49.99m, Category = "Home Appliances" }
    };

    [HttpGet(Name = "GetProducts")]
    public IEnumerable<Product> Get()
    {
        return _products;
    }

    [HttpGet("{id}", Name = "GetProductById")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return product;
    }
}