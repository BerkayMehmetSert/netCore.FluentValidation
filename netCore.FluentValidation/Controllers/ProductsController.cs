using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netCore.FluentValidation.Models;
using netCore.FluentValidation.Responses;
using static netCore.FluentValidation.Constants.ProductMessage;
namespace netCore.FluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private List<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Description 1",
                    Price = 10
                },
                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Description 2",
                    Price = 20
                }
            };
        }

        [HttpGet]
        public BaseResponse<List<Product>> GetAllProducts()
        {
            var products = GetProductList();
            return new BaseResponse<List<Product>>(products);
        }


        [HttpGet("{id}")]
        public BaseResponse<Product> GetProductById([FromRoute] int id)
        {
            var product = GetProductList().FirstOrDefault(x => x.Id == id);

            return product is null ? new BaseResponse<Product>(ProductNotFoundById) : new BaseResponse<Product>(product);
        }


        [HttpPost]
        public BaseResponse<Product> CreateProduct([FromBody] Product request)
        {
            var products = GetProductList();
            products.Add(request);

            return new BaseResponse<Product>(request);
        }


        [HttpPut("{id}")]
        public BaseResponse<Product> UpdateProduct([FromRoute] int id, [FromBody] Product request)
        {
            var list = GetProductList();
            var product = list.FirstOrDefault(x => x.Id == id);

            if (product is null)
            {
                return new BaseResponse<Product>(ProductNotFoundById);
            }

            list.Remove(product);
            list.Add(request);

            return new BaseResponse<Product>(request);
        }


        [HttpDelete("{id}")]
        public BaseResponse<Product> DeleteProduct([FromRoute]int id)
        {
            var list = GetProductList();
            var product = list.FirstOrDefault(x => x.Id == id);

            if (product is null)
            {
                return new BaseResponse<Product>(ProductNotFoundById);
            }

            list.Remove(product);
            return new BaseResponse<Product>(product);
        }
    }
}
