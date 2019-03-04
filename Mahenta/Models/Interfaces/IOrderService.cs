using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mahenta.Models.Interfaces
{
    /// <summary>
    /// This interface defines our required methods to interact with the 
    /// database with relation to orders
    /// </summary>
    public interface IOrderService
    {
        // These method signatures define the CRUD operations
        // for Order Service
        
        // Create
        Task<HttpStatusCode> CreateOrder(Order order);

        // Read
        Task<List<Order>> GetOrders();
        Task<Order> GetOrderByID(int id);

        // Update
        Task<HttpStatusCode> UpdateOrder(int id, Order order);

        // Delete
        Task<HttpStatusCode> DeleteOrder(int id);
    }
}
