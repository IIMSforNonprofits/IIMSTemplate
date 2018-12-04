using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IIMStemplate.Models.Handlers
{
    public class StatusRequirement : IAuthorizationRequirement
    {
        public Status Status { get; set; }

        public StatusRequirement(Status status)
        {
            Status = status;
        }
    }
}
