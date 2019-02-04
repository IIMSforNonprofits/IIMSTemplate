using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mahenta.Models.Interfaces
{
    /// <summary>
    /// This interface defines our required methods to interact with the 
    /// database with relation to donors
    /// </summary>
    public interface IDonorService
    {
        // These method signatures define the CRUD operations
        // for Donor Service

        // Create
        Task<HttpStatusCode> CreateDonor(Donor donor);

        // Read
        Task<IEnumerable<Donor>> GetDonors();
        Task<Donor> GetDonorByID(int id);

        // Update
        Task<HttpStatusCode> UpdateDonor(int id, Donor donor);

        // Delete
        Task<HttpStatusCode> DeleteDonor(int id);
    }
}
