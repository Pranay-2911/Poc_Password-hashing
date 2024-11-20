using Poc_Password_hashing.Dtos;
using Poc_Password_hashing.Models;

namespace Poc_Password_hashing.Services
{
    public interface IUserService
    {
        public Guid Add(UserDto user);
        public bool Login(LoginDto login);  
    }
}
