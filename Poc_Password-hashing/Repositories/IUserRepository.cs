using Poc_Password_hashing.Models;

namespace Poc_Password_hashing.Repositories
{
    public interface IUserRepository
    {
        public void Add(User user);
        public User GetByName(string name);
    }
}
