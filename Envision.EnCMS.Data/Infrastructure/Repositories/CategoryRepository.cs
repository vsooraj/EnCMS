using Envision.EnCMS.Data.Infrastructure.Repositories.Abstract;
using Envision.EnCMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Envision.EnCMS.Data.Infrastructure.Repositories
{
    public class CategoryRepository : EntityBaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(EnCMSContext context)
            : base(context)
        { }

    }
}
