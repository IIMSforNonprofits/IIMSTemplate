using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mahenta.Models
{
    public class Order
    {
        public int ID { get; set; }
        [Required]
        public string EmployeeID { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime ShipDate { get; set; }
        public bool AcceptPartialShip { get; set; }
        public int PartialOrderID { get; set; }
        public List<Product> Products { get; set; }
    }
}
