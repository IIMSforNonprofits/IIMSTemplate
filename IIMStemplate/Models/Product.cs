using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IIMStemplate.Models
{
    public class Product
    {
        public int ID { get; set; }
        //TODO: Need to make an OrderItem model to tie together
        //products to orders as a junction table
        //public int OrderID { get; set; }
        [Required]
        public int DonorID { get; set; }
        [Required]
        public string Sku { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Condition { get; set; }
        public string Size { get; set; } //Possible to use enum (from Eric)
        public string Color { get; set; }
        public string Use { get; set; }
        public Availability Availability { get; set; }
        public string EstimatedValue { get; set; }
    }

    public enum Availability
    {
        Available, //0
        Claimed, //1
        Shipped, //2
    }
}
