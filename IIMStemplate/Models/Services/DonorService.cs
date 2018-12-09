using IIMStemplate.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IIMStemplate.Models
{
    public class DonorService : IDonorService
    {
        public Task<HttpStatusCode> CreateDonor(Donor donor)
        {
            throw new NotImplementedException();
        }

        public Task<HttpStatusCode> DeleteDonor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Donor> GetDonorByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Donor> UpdateDonor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
