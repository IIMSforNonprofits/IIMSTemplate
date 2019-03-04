using Mahenta.Data;
using Mahenta.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mahenta.Models
{
    public class InventoryService : IInventoryService
    {
        private InvMgmtDbContext _context;

        /// <summary>
        /// This constructor initializes the dependency injection
        /// </summary>
        /// <param name="context">This will be the database context that we are using</param>
        public InventoryService(InvMgmtDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method creates an product
        /// </summary>
        /// <param name="product">The product that we are creating</param>
        /// <returns>A Status Code of 400 for a bad request or a 201 for a created product</returns>
        public async Task<HttpStatusCode> CreateProduct(Product product)
        {
            var result = await _context.Products.AddAsync(product);
            if (result == null)
            {
                return HttpStatusCode.BadRequest;
            }
            await _context.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        /// <summary>
        /// This method deletes a product
        /// </summary>
        /// <param name="id">This is the id of the product to delete</param>
        /// <returns>A Status Code of 400 for a bad request or 200 for a successful deletion</returns>
        public async Task<HttpStatusCode> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ID == id);
            if (product == null)
            {
                return HttpStatusCode.BadRequest;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return HttpStatusCode.OK;
        }
        
        /// <summary>
        /// This method gets a specific product
        /// </summary>
        /// <param name="id">This is the id of the product we are getting</param>
        /// <returns>The product that has been retrieved or null if nothing is retrieved</returns>
        public async Task<Product> GetProductByID(int id)
        {
            // TODO: A null check for detail view for Product on the front end
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ID == id);
            return product;
        }

        /// <summary>
        /// This method gets all products
        /// </summary>
        /// <returns>A list of all products in the database or null if there is nothing</returns>
        public async Task<List<Product>> GetProducts()
        {
            // TODO: A null check for Products on the front end
            List<Product> products = await _context.Products.ToListAsync();
            return products;
        }
        
        /// <summary>
        /// This method updates a product
        /// </summary>
        /// <param name="id">The id of the product to update</param>
        /// <param name="product">The updated version of the product</param>
        /// <returns>A Status Code of 400 for a bad request or a 200 for a successful update</returns>
        public async Task<HttpStatusCode> UpdateProduct(int id, Product product)
        {
            var updateProduct = _context.Products.FirstOrDefault(p => p.ID == id);
            if (updateProduct == null)
            {
                return HttpStatusCode.BadRequest;
            }
            _context.Entry(updateProduct).State = EntityState.Detached;
            product.ID = id;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return HttpStatusCode.OK;
        }
    }
}
