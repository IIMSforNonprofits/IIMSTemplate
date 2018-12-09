using IIMStemplate.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IIMStemplate.Models
{
    public class InventoryService : IInventoryService
    {
        public Task<HttpStatusCode> CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<HttpStatusCode> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<HttpStatusCode> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
