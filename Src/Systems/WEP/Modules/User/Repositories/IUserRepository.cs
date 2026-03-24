using WepAPI.Src.WEP.Modules.Users.Entities;

namespace WepAPI.Src.WEP.Modules.Users.Repositories;

/// <summary>
/// Define las operaciones de acceso a datos para la entidad User.
/// </summary>
public interface IUserRepository: ICrudRepository<User, Guid>
{
    
}