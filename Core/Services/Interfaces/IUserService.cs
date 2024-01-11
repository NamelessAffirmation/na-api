using Data.Entities.Interfaces;

namespace Core.Services.Interfaces;

public interface IUserService
{
    IUser GetUserById(int id);
}