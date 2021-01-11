using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Product.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>()
        {
            new Product(){Id=1,Name="Carfoure Ürün 1",Price=10},
            new Product(){Id=2,Name="Carfoure Ürün 2",Price=12},
            new Product(){Id=3,Name="Carfoure Ürün 3",Price=14},
            new Product(){Id=4,Name="Carfoure Ürün 4",Price=16},
            new Product(){Id=5,Name="Carfoure Ürün 5",Price=18},
            new Product(){Id=6,Name="Carfoure Ürün 6",Price=20},
        };
     

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Product> Get()
        {
            var rng = new Random();
            return Products.ToList();
        }
    }
}
