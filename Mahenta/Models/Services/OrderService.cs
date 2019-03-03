using Mahenta.Data;
using Mahenta.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mahenta.Models.Services
{
    public class OrderService : IOrderService
    {
        private InvMgmtDbContext _context;

        /// <summary>
        /// This constructor initializes the dependency injection
        /// </summary>
        /// <param name="context">This will be the database context that we are using</param>
        public OrderService(InvMgmtDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method creates an order
        /// </summary>
        /// <param name="order">The order that we are creating</param>
        /// <returns>A Status Code of 400 for a bad request or a 201 for a created order</returns>
        public async Task<HttpStatusCode> CreateOrder(Order order)
        {
            var result = await _context.Orders.AddAsync(order);
            if (result == null)
            {
                return HttpStatusCode.BadRequest;
            }
            await _context.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        /// <summary>
        /// This method deletes an order
        /// </summary>
        /// <param name="id">This is the id of the order to delete</param>
        /// <returns>A Status Code of 400 for a bad request or 200 for a successful deletion</returns>
        public async Task<HttpStatusCode> DeleteOrder(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(p => p.ID == id);
            if (order == null)
            {
                return HttpStatusCode.BadRequest;
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return HttpStatusCode.OK;
        }

        /// <summary>
        /// This method gets a specific order
        /// </summary>
        /// <param name="id">This is the id of the order we are getting</param>
        /// <returns>The order that has been retrieved or null if nothing is retrieved</returns>
        public async Task<Order> GetOrderByID(int id)
        {
            // TODO: A null check for detail view for Order on the front end
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.ID == id);
            return order;
        }

        /// <summary>
        /// This method gets all orders
        /// </summary>
        /// <returns>A list of all orders in the database or null if there is nothing</returns>
        public async Task<List<Order>> GetOrders()
        {
            // TODO: A null check for Orders on the front end
            List<Order> orders = await _context.Orders.ToListAsync();
            return orders;
        }

        /// <summary>
        /// This method updates an order
        /// </summary>
        /// <param name="id">The id of the order to update</param>
        /// <param name="order">The updated version of the order</param>
        /// <returns>A Status Code of 400 for a bad request or 200 for a successful update</returns>
        public async Task<HttpStatusCode> UpdateOrder(int id, Order order)
        {
            var updateOrder = await _context.Orders.FirstOrDefaultAsync(o => o.ID == id);
            if (updateOrder == null)
            {
                return HttpStatusCode.BadRequest;
            }
            _context.Entry(updateOrder).State = EntityState.Detached;
            order.ID = id;
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
    }
}
