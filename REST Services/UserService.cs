using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JsonThreadOperation.Model;

namespace REST_Services
{
    public interface IUserService
    {
        Result RegisterUser(User user);
    }
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserService userService)
        {
            _userRepository = userRepository;
        }
        public Result RegisterUser(User user)
        {
            if(string.IsNullOrEmpty(user.Name) || string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            {
                return new Result { Success = false, Message = "Please fill out all fields" };
            }
            var existingUser = _userRepository.GetUserByEmail(user.Email);
            if(existingUser!= null)
            {
                return new Result { Success = false, Message = "User already exists" };
            }
            _userRepository.CreateUser(user);
            return new Result { Success = true, Message = "User registered successfully" };
        }
    }
}