using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.WebApi.Controllers
{
    [RoutePrefix("products")] // Bruges hvis man ikke vil bruge default routning
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
            new Product {PartitionKey="ProductKey", RowKey = "0", Name = "Gummibolde", Category = "Legetøj", Price = 17.95 },
            new Product {PartitionKey="ProductKey", RowKey = "1", Name = "Hoppeborge", Category = "Legetøj", Price = 2595.00 },
            new Product {PartitionKey="ProductKey", RowKey = "2", Name = "Blyanter", Category = "Skoleredskaber", Price = 5.25 },
            new Product {PartitionKey="ProductKey", RowKey = "3", Name = "Kuglepenne", Category = "Skoleredskaber", Price = 17.95 },
            new Product {PartitionKey="ProductKey", RowKey = "4", Name = "Linealer", Category = "Skoleredskaber", Price = 22.50 }
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
            //return products;  FØR Azure

            CloudTableClient tableClient = CreateTableClient();
            CloudTable table = tableClient.GetTableReference("Products");
            var query =
                from entity in table.CreateQuery<Product>()
                where entity.PartitionKey == "ProductKey"
                select entity;

            return query;

        }


        [Route("{id}")]  // Skal med hvis [RoutePrefix]
        [HttpGet]        // Skal med hvis [RoutePrefix]
        public Product GetProduct(string id)
        {
            //foreach (var product in products)  FØR Azure
            //{
            //    if (product.RowKey == id)
            //    {
            //        return product;
            //    };
            //};

            CloudTableClient tableClient = CreateTableClient();
            CloudTable table = tableClient.GetTableReference("Products");
            var query =
                from entity in table.CreateQuery<Product>()
                where entity.PartitionKey == "ProductKey" && entity.RowKey == id
                select entity;

            var res = query.SingleOrDefault(p => p.RowKey == id);

            return res;

            //throw new NotFoundException();

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

        private CloudTableClient CreateTableClient()
        {
            CloudStorageAccount storageAccount =
                CloudStorageAccount.Parse(
                    ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString);

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            return tableClient;

        }


        internal void InitializeSampleData()
        {
            CloudTableClient tableClient = CreateTableClient();

            CloudTable table = tableClient.GetTableReference("Products");

            table.CreateIfNotExists();

            foreach (var product in products)
            {
                var insertORreplace = TableOperation.InsertOrReplace(product);
                table.Execute(insertORreplace);
            };


        }


    }
}
