using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Mahenta.Models;
using Mahenta.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//TODO : error handling for null values
namespace Mahenta.Controllers
{
    [Route("api/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventory;
        private JsonSerializer _serializer = new JsonSerializer();

        public InventoryController(IInventoryService inventory)
        {
            _inventory = inventory;
        }

        // GET: api/<controller>
        /// <summary>
        /// This endpoint is used to retrieve all products
        /// </summary>
        /// <returns>A string which holds all products in the database</returns>
        [HttpGet]
        public async Task<string> Get()
        {
            // Method to interact with the Data Access Layer with the Inventory Database
            List<Product> inventory = await _inventory.GetProducts();

            // This serializes the inventory and stores it into a string
            string stringifiedProducts = JsonConvert.SerializeObject(inventory);
            return stringifiedProducts;
        }

        // GET api/<controller>/5
        /// <summary>
        /// This endpoint is used to retrieve one product based off of the ID
        /// </summary>
        /// <param name="id">The id of the product to find</param>
        /// <returns>A string containing the information of the product</returns>
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            // Method to interact with the Data Access Layer with the Inventory Database
            Product product = await _inventory.GetProductByID(id);

            // This serializes the product and stores it into the JSON object declared above.
            string stringifiedProduct = JsonConvert.SerializeObject(product);
            return stringifiedProduct;
        }

        // POST api/<controller>   
        /// <summary>
        /// This endpoint is used to create a new product from the incoming
        /// JSON object
        /// </summary>
        /// <param name="value">JSON object</param>
        /// <returns>Status Code to signify success/fail</returns>
        [HttpPost]
        public async Task<HttpStatusCode> Post([FromBody]JObject value)
        {
            // _serializer is instantiated as a privtae field. It is casted to a type of
            // product and deserializes the JSON tokens into the appropriate Product fields
            Product newProduct = (Product)_serializer.Deserialize(new JTokenReader(value), typeof(Product));
            // Method to interact with the Data Access Layer with the Inventory Database
            return await _inventory.CreateProduct(newProduct);
        }

        // PUT api/<controller>/5
        /// <summary>
        /// This endpoint is used to update an existing product with new values
        /// </summary>
        /// <param name="id">The id of the product to update</param>
        /// <param name="value">JSON object</param>
        /// <returns>Status Code to signify success/fail</returns>
        [HttpPut("{id}")]
        public async Task<HttpStatusCode> Put(int id, [FromBody]JObject value)
        {
            // Deserializes the JSON tokens into the appropriate Product fields
            // and stores it into the updateProduct variable.
            Product updateProduct = (Product)_serializer.Deserialize(new JTokenReader(value), typeof(Product));
            // Method to interact with the Data Access Layer with the Inventory Database
            return await _inventory.UpdateProduct(id, updateProduct);
        }

        // DELETE api/<controller>/5
        /// <summary>
        /// This endpoint is used to delete an existing product
        /// </summary>
        /// <param name="id">The id of the product to delete</param>
        /// <returns>Status Code to signify success/fail</returns>
        [HttpDelete("{id}")]
        public async Task<HttpStatusCode> Delete(int id)
        {
            // Method to interact with the Data Access Layer with the Inventory Database
            return await _inventory.DeleteProduct(id);
        }
    }
}