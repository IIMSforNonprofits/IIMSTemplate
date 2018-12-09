using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace IIMStemplate.Models.Interfaces
{
    interface IUserManagementService
    {
        // These method signatures define the basic CRUD operations
        // for user management
        Task<HttpStatusCode> CreateUser(ApplicationUser user);
        Task<ApplicationUser> GetUserByID(string id);
        Task<ApplicationUser> UpdateUser(string id);
        Task<HttpStatusCode> DeleteUser(string id);
    }
}
