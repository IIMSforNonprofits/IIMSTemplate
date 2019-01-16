using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IIMStemplate.Models.Interfaces
{
    /// <summary>
    /// This interface defines our required methods to interact with the inventory
    /// database with relation to products and orders
    /// </summary>
    public interface IInventoryService
    {
        // These method signatures define CRUD operations
        // for product
        Task<List<Product>> GetProducts();
        Task<HttpStatusCode> CreateProduct(Product product);
        Task<Product> GetProductByID(int id);
        Task<HttpStatusCode> UpdateProduct(int id, Product product);
        Task<HttpStatusCode> DeleteProduct(int id);
        // These method signatures define the operations 
        // for orders
        Task<List<Order>> GetOrders();
        Task<HttpStatusCode> CreateOrder(Order order);
        Task<Order> GetOrderByID(int id);
        Task<HttpStatusCode> UpdateOrder(int id, Order order);

    }
}
