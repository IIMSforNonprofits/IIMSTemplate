using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mahenta.Models
{
    public class Donor
    {
        public int ID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DonorName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string CompanyName { get; set; }
        //3 separate fields in the form concatenated with commas when input
        public string Address { get; set; }
        public string JobTitle { get; set; }
        public DonorEntity DonorEntity { get; set; }
        public int TotalDonations { get; set; }

        /// <summary>
        /// This method changes all properties in the current donor to be the same as the one provided.
        /// </summary>
        /// <param name="donor">The up to date donor</param>
        public void UpdateDonor(Donor donor)
        {
            Email = donor.Email;
            DonorName = donor.DonorName;
            PhoneNumber = donor.PhoneNumber;
            CompanyName = donor.CompanyName;
            Address = donor.Address;
            JobTitle = donor.JobTitle;
            DonorEntity = donor.DonorEntity;
            TotalDonations = donor.TotalDonations;
        }
    }

    public enum DonorEntity
    {
        Personal, //0
        Small_Business, //1
        Enterprise, //2
    }
}
