using Envision.EnCMS.Data.Infrastructure.Repositories.Abstract;
using Envision.EnCMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Envision.EnCMS.Data.Infrastructure.Repositories
{
    public class AlbumRepository : EntityBaseRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(EnCMSContext context)
            : base(context)
        { }
    }
}
