using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mahenta.Models.Interfaces
{
    /// <summary>
    /// This interface defines our required methods to interact with the inventory
    /// database with relation to products
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
    }
}
