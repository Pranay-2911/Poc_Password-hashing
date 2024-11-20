using Poc_Password_hashing.Data;
using Poc_Password_hashing.Models;

namespace Poc_Password_hashing.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext; 
        }
        public void Add(User user)
        {
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
        }

        public User GetByName(string name)
        {
            return _userContext.Users.FirstOrDefault(u => u.UserName == name);
        }
    }
}
