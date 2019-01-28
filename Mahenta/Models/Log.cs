using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mahenta.Models
{
    public class Log
    {
        public int ID { get; set; }
        [Required]
        public string EmployeeID { get; set; }
        [Required]
        public string ActionTaken { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
    }
}
