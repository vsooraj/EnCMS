using Envision.EnCMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Envision.EnCMS.Data.Infrastructure.Core
{
    public class MembershipContext
    {
        public IPrincipal Principal { get; set; }
        public User User { get; set; }
        public bool IsValid()
        {
            return Principal != null;
        }
    }
}
