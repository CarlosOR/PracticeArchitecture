using Practice.Architecture.Models.Entities;

namespace Practice.Architecture.Domain.Interfaces.Users
{
    public interface IUserDomainService
    {
        User GetUserById(int id);
        int SaveUser(User user);
    }
}
