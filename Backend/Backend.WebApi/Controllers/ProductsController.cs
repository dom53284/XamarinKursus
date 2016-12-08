using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.WebApi.Controllers
{
    [RoutePrefix("products")] // Bruges hvis Products skal hedde noget andet
    public class ProductsController : ApiController
    {
        private Review[] reviews = new Review[]
        {
            new Review {Id=2 , ProductId=0, Rating=3, Text="Gummibolde" },
            new Review {Id=4 , ProductId=1, Rating=3, Text="Hoppeborge" },
            new Review {Id=6 , ProductId=4, Rating=4, Text="Blyanter" },
            new Review {Id=8 , ProductId=4, Rating=4, Text="Kuglepenne" },
            new Review {Id=10 , ProductId=4, Rating=5, Text="Linealer" }
        };


        private Product[] products = new Product[]
        {
            new Product {Id = 0, Name = "Gummibolde", Category = "Legetøj", Price = 17.95m },
            new Product {Id = 1, Name = "Hoppeborge", Category = "Legetøj", Price = 2595.00m },
            new Product {Id = 2, Name = "Blyanter", Category = "Skoleredskaber", Price = 5.25m },
            new Product {Id = 3, Name = "Kuglepenne", Category = "Skoleredskaber", Price = 17.95m },
            new Product {Id = 4, Name = "Linealer", Category = "Skoleredskaber", Price = 22.50m }
        };


        [Route("{productid}/reviews")]  // Skal med hvis [RoutePrefix]
        [HttpGet]    // Skal med hvis [RoutePrefix]
        public IEnumerable<Review> GetRevievsForProduct(int productId)
        {
            return this.reviews.Where(p => p.ProductId == productId);
        }


        [Route("")]  // Skal med hvis [RoutePrefix]
        [HttpGet]    // Skal med hvis [RoutePrefix]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }


        [Route("{id}")]  // Skal med hvis [RoutePrefix]
        [HttpGet]        // Skal med hvis [RoutePrefix]
        public Product GetProduct(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return product;
                };
            };

            throw new NotFoundException();

            //return null;

            //// Alternativ måde med LINQ og anden result-type
            //public IHttpActionResult GetProduct(int id)
            //
            //var product = this.products.Where(p => p.Id == id)
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
