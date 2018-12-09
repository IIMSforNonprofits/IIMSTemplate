using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IIMStemplate.Models
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
    }

    public enum DonorEntity
    {
        Personal, //0
        Small_Business, //1
        Enterprise, //2
    }
}
