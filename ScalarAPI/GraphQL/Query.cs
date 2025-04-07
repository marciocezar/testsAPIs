using System.Collections.Generic;
using System.Linq;
using HotChocolate;
using ScalarAPI;

public class Query
{
    private static readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 1299.99m, Category = "Electronics" },
        new Product { Id = 2, Name = "Smartphone", Price = 799.99m, Category = "Electronics" },
        new Product { Id = 3, Name = "Coffee Maker", Price = 89.99m, Category = "Home Appliances" },
        new Product { Id = 4, Name = "Headphones", Price = 199.99m, Category = "Electronics" },
        new Product { Id = 5, Name = "Toaster", Price = 49.99m, Category = "Home Appliances" }
    };

    public IEnumerable<Product> GetProducts() => _products;

    public Product? GetProduct(int id) => _products.FirstOrDefault(p => p.Id == id);
}