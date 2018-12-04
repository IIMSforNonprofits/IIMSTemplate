using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IIMStemplate.Models.Handlers
{
    public class StatusHandler : AuthorizationHandler<StatusRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, StatusRequirement requirement)
        {
            if(!context.User.HasClaim(c => c.Type == "Status"))
            {
                return Task.CompletedTask;
            }

            var userStatus = context.User.FindFirst(c => c.Type == "Status").Value;

            //if(userStatus == requirement.Status)
            //{
            //    context.Succeed(requirement);
            //}

            return Task.CompletedTask;
        }
    }
}
