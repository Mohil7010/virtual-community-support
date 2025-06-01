
using BooksApi.Entities.Entities;
using BooksApi.Models;

using System.Threading.Tasks;
using UserEntity = BooksApi.Entities.Entities.User;

namespace BooksApi.Services.Services.Interface
{
    public interface IUserService
    {
        Task AddUser(UserEntity user);
        UserEntity? Login(string username, string password);
    }
}

