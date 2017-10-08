using Envision.EnCMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Envision.EnCMS.Data.Infrastructure.Repositories.Abstract
{
    public interface IAlbumRepository : IEntityBaseRepository<Album> { }
    public interface ICategoryRepository : IEntityBaseRepository<Category> { }
    public interface IGadgetRepository : IEntityBaseRepository<Gadget> { }
    public interface ILoggingRepository : IEntityBaseRepository<Error> { }

    public interface IPhotoRepository : IEntityBaseRepository<Photo> { }

    public interface IRoleRepository : IEntityBaseRepository<Role> { }

    public interface IUserRepository : IEntityBaseRepository<User>
    {
        User GetSingleByUsername(string username);
        IEnumerable<Role> GetUserRoles(string username);
    }

    public interface IUserRoleRepository : IEntityBaseRepository<UserRole> { }

}
