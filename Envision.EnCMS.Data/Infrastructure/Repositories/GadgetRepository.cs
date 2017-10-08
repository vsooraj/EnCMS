using Envision.EnCMS.Data.Infrastructure.Repositories.Abstract;
using Envision.EnCMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Envision.EnCMS.Data.Infrastructure.Repositories
{
    public class GadgetRepository : EntityBaseRepository<Gadget>, IGadgetRepository
    {
        public GadgetRepository(EnCMSContext context)
            : base(context)
        { }
    }

   
}
