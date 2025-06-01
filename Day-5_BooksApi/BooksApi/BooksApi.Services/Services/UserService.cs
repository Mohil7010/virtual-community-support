using UserEntity = BooksApi.Entities.Entities.User;
using BooksApi.Entities.Repositories.Interface;
using BooksApi.Models;
using BooksApi.Services.Services.Interface;

namespace BooksApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Add a user
        public async Task AddUser(UserEntity user)
        {
            await _userRepository.AddUser(user);
        }

        // User login
        public UserEntity? Login(string username, string password)
        {
            return _userRepository.Login(username, password);
        }
    }
}
