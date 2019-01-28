using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mahenta.Models.Interfaces
{
    interface IDonorService
    {
        // These method signatures define the CRUD operations
        // for Donor Service
        Task<HttpStatusCode> CreateDonor(Donor donor);
        Task<Donor> GetDonorByID(int id);
        Task<Donor> UpdateDonor(int id);
        Task<HttpStatusCode> DeleteDonor(int id);
    }
}
