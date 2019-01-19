using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using IIMStemplate.Models;
using IIMStemplate.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//TODO : error handling for null values
namespace IIMStemplate.Controllers
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
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>   
        /// <summary>
        /// This endpoint is used to create a new product from the incoming
        /// JSON object
        /// </summary>
        /// <param name="value">JSON object</param>
        /// <returns>StatusCode to signify success/fail</returns>
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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
