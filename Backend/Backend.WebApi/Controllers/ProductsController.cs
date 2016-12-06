using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.WebApi.Controllers
{
    [RoutePrefix("api/products")] // Bruges hvis Products skal hedde noget andet
    public class ProductsController : ApiController
    {

        private Product[] products = new Product[]
        {
            new Product {Id = 0, Name = "Gummibolde", Category = "Legetøj", Price = 17.95m },
            new Product {Id = 1, Name = "Hoppeborge", Category = "Legetøj", Price = 2595.00m },
            new Product {Id = 2, Name = "Blyanter", Category = "Skoleredskaber", Price = 5.25m },
            new Product {Id = 3, Name = "Kuglepenne", Category = "Skoleredskaber", Price = 17.95m },
            new Product {Id = 4, Name = "Linealer", Category = "Skoleredskaber", Price = 22.50m }
        };

        [Route("")]  // Skal med hvis [RoutePrefix]
        [HttpGet]    // Skal med hvis [RoutePrefix]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }


        public IHttpActionResult GetProduct(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return Ok(product);
                };
            };
            return NotFound();

            //// Alternativ måde med link
            //var product = this.products.Where(p = > p.Id == id)
            //    .SingleOrDefault();
            //if (product == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    return Ok(product);
            //};

        }

    }
}
