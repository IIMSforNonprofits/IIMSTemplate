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
    public class DonorService : IDonorService
    {
        private InvMgmtDbContext _context;
        /// <summary>
        /// This constructor initializes the dependency injection
        /// </summary>
        /// <param name="context">This is the database context that will be used</param>
        public DonorService(InvMgmtDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method gets all donors
        /// </summary>
        /// <returns>a list of all donors in the database or null if there is nothing</returns>
        public async Task<IEnumerable<Donor>> GetDonors()
        {
            // TODO: A null check for Donors on the front end
            IEnumerable<Donor> donors = await _context.Donors.ToListAsync();
            return donors;
        }

        /// <summary>
        /// This method gets a specific donor
        /// </summary>
        /// <param name="id">This is the id of the donor</param>
        /// <returns>The donor that has been retrieved from the database or null if there is nothing</returns>
        public async Task<Donor> GetDonorByID(int id)
        {
            // TODO: A null check for detail view for Donor on the front end
            Donor donor = await _context.Donors.FirstOrDefaultAsync(d => d.ID == id);
            return donor;
        }

        /// <summary>
        /// This method adds a donor to the database
        /// </summary>
        /// <param name="donor">The donor to be added to the database</param>
        /// <returns>A Status Code of 400 for a bad request or 201 for an added donor</returns>
        public async Task<HttpStatusCode> CreateDonor(Donor donor)
        {
            var result = await _context.Donors.AddAsync(donor);
            if (result == null)
            {
                return HttpStatusCode.BadRequest;
            }
            await _context.SaveChangesAsync();
            return HttpStatusCode.Created;
        }

        /// <summary>
        /// This method updates a donor in the database
        /// </summary>
        /// <param name="id">The id of the donor to update</param>
        /// <param name="donor">The updated information for the donor</param>
        /// <returns>A Status Code of 400 for a bad request or 200 for a successful update</returns>
        public async Task<HttpStatusCode> UpdateDonor(int id, Donor donor)
        {
            var updateDonor = await _context.Donors.FirstOrDefaultAsync(d => d.ID == id);
            if (updateDonor == null)
            {
                return HttpStatusCode.BadRequest;
            }
            // This method changes all properties (except ID) of updateDonor to be the same as Donor
            updateDonor.UpdateDonor(donor);
            _context.Donors.Update(updateDonor);
            await _context.SaveChangesAsync();
            return HttpStatusCode.OK;
        }

        /// <summary>
        /// This method deletes a donor from the database
        /// </summary>
        /// <param name="id">The id of the donor to delete</param>
        /// <returns>A Status Code of 400 for a bad request or 200 for a successful deletion</returns>
        public async Task<HttpStatusCode> DeleteDonor(int id)
        {
            Donor donor = await _context.Donors.FirstOrDefaultAsync(d => d.ID == id);
            if (donor == null)
            {
                return HttpStatusCode.BadRequest;
            }

            _context.Donors.Remove(donor);
            await _context.SaveChangesAsync();

            return HttpStatusCode.OK;
        }
    }
}
