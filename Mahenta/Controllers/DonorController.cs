using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Mahenta.Models;
using Mahenta.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
// TODO: error handling for null values
namespace Mahenta.Controllers
{
    [Route("api/donor")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        private IDonorService _donorService;
        private JsonSerializer _serializer = new JsonSerializer();

        public DonorController(IDonorService donorService)
        {
            _donorService = donorService;
        }
        // GET: api/<controller>
        /// <summary>
        /// This endpoint is used to retrieve all donors
        /// </summary>
        /// <returns>A string which holds all donors in the database</returns>
        [HttpGet]
        public async Task<string> Get()
        {
            // Method to interact with the Data Access Layer with the Donor Database
            IEnumerable<Donor> donors = await _donorService.GetDonors();

            // This serializes the inventory and stores it into a string
            string stringifiedDonors = JsonConvert.SerializeObject(donors);
            return stringifiedDonors;
        }

        // POST: api/<controller>
        /// <summary>
        /// This endpoint is used to create a new donor from the incoming 
        /// JSON object
        /// </summary>
        /// <param name="value">JSON object</param>
        /// <returns>Status Code to signify success/fail</returns>
        [HttpPost]
        public async Task<HttpStatusCode> Post([FromBody]JObject value)
        {
            // _serializer is instantiated as a privtae field. It is casted to a type of
            // donor and deserializes the JSON tokens into the appropriate Donor fields
            Donor newDonor = (Donor)_serializer.Deserialize(new JTokenReader(value), typeof(Donor));
            // Method to interact with the Data Access Layer with the Donor Table
            return await _donorService.CreateDonor(newDonor);
        }
    }
}
