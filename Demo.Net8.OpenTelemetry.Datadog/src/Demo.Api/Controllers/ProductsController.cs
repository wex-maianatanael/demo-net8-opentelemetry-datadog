using Microsoft.AspNetCore.Mvc;

namespace Demo.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpPost()]
        public IActionResult Post([FromBody] Product model)
        {
            _logger.LogInformation("### Create new model ###");

            var response = new Product
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price
            };

            return Ok(response);
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            _logger.LogInformation("### Get model by id ###");

            var product1 = new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 100
            };

            var product2 = new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 150
            };

            var products = new List<Product> { product1, product2 };

            return Ok(products);
        }

        [HttpGet("{productId:int}")]
        public IActionResult Get(int productId)
        {
            _logger.LogInformation("### Get model by id ###");

            var product = new Product
            {
                Id = productId,
                Name = "Product 1",
                Price = 100
            };

            return Ok(product);
        }

        [HttpPut("{productId:int}")]
        public IActionResult Put(int productId, [FromBody] Product model)
        {
            _logger.LogInformation("### Update model ###");

            var product = new Product
            {
                Id = productId,
                Name = model.Name,
                Price = model.Price
            };

            return Ok(product);
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
