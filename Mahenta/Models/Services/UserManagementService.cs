using Mahenta.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mahenta.Models
{
    public class UserManagementService : IUserManagementService
    {
        public Task<HttpStatusCode> CreateUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public Task<HttpStatusCode> DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> GetUserByID(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUser> UpdateUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}
