using AutoMapper;
using Poc_Password_hashing.Dtos;
using Poc_Password_hashing.Exceptions;
using Poc_Password_hashing.Models;
using Poc_Password_hashing.Repositories;

namespace Poc_Password_hashing.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public Guid Add(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto); // the encrption is done in the mappers
            _userRepository.Add(user);
            return user.id;
        }

        public bool Login(LoginDto login)
        {
            var user = _userRepository.GetByName(login.UserName);
            if (user == null)
            {
                throw new UserNotFoundException("NO such User Found with this username and Password");
            }
            if(BCrypt.Net.BCrypt.Verify(login.Password, user.PasswordHash)) // password Decription is done 
            {
                return true;
            }
            return false;
        }
    }
}
