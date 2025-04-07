using LibraryManagmentProject.interfaces;
using LibraryManagmentProject.Models;
using LibraryManagmentProject.Repositories;
using System;

namespace LibraryManagmentProject.Services
{
    public class UserService
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly UserRepository _userRepository;

        public UserService(IPasswordHasher passwordHasher, UserRepository userRepository)
        {
            _passwordHasher = passwordHasher;
            _userRepository = userRepository;
        }

        public bool RegisterUser(string username, string password)
        {
            var existingUser = _userRepository.GetUserByUsername(username);
            if (existingUser != null)
            {
                return false; // User already exists
            }

            var passwordHash = _passwordHasher.Hash(password);

            var user = new User
            {
                UserName = username,
                HashedPassword = passwordHash,
            };

            _userRepository.RegistryUser(user);
            return true;
        }

        public bool LoginUser(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);
            if (user == null)
            {
                return false; // User not found
            }

            return _passwordHasher.Verify(user.HashedPassword, password);
        }
    }
}
