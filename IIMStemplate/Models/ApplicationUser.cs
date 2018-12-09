using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IIMStemplate.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public Status Status { get; set; }
        public DateTime DateOfLastAction { get; set; }
        public string ColorScheme { get; set; }
        public string UserPreferences { get; set; }
    }

    /// <summary>
    /// Here we store the information for what each specific role is called. 
    /// It is stored here to prevent spelling errors when assigning roles.
    /// </summary>
    public static class ApplicationRoles
    {
        public const string WebMaster = "Web Master";
        public const string Admin = "Admin";
        public const string Employee = "Employee";
        public const string Volunteer = "Volunteer";
    }

    /// <summary>
    /// Here we hold the terms for the status of the user
    /// </summary>
    public enum Status
    {
        Pending, //0
        Active, //1
        Inactive, //2
    }
}
