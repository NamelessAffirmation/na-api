using Core.Services.Interfaces;
using Data.Entities.Impl;
using Data.Entities.Interfaces;

namespace Core.Services.Impl;

public class UserService : IUserService
{
    public IUser GetUserById(int id)
    {
        var testUser = new User
        {
            Id = id,
            Email = "test@example.com"
        };
        return testUser;
    }
}