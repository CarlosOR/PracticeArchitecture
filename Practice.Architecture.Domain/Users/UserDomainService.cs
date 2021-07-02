using Practice.Architecture.Models.Entities;
using Practice.Architecture.Domain.Interfaces.Users;
using Practice.Architecture.Persistence.Interfaces.Repositories;
using Practice.Architecture.Persistence.Interfaces.Infraestructure;

namespace Practice.Architecture.Domain.Users
{
    public class UserDomainService : IUserDomainService
    {
        public readonly IRepository<User> _repoUser;
        public readonly IUnitOfWork _unitOfWork;

        public UserDomainService(IRepository<User> repository, IUnitOfWork unitOfWork)
        {
            _repoUser = repository;
            _unitOfWork = unitOfWork;
        }

        public User GetUserById(int id)
        {
            return _repoUser.GetById(id);
        }

        public int SaveUser(User user)
        {
            _repoUser.Save(user);
            _unitOfWork.Commit();
            return user.Id;
        }
    }
}
