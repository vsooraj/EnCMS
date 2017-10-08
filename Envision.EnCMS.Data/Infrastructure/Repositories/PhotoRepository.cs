using Envision.EnCMS.Data.Infrastructure.Repositories.Abstract;
using Envision.EnCMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Envision.EnCMS.Data.Infrastructure.Repositories
{
    public class PhotoRepository : EntityBaseRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(EnCMSContext context)
            : base(context)
        { }
    }
}
