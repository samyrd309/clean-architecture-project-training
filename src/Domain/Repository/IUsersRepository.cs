using CleanArchitectureImplementation.Domain.Entities;

namespace CleanArchitectureImplementation.Domain.Repository
{
    public interface IUsersRepository
    {
        Task<User> GetUserByIdAsync(int userId);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> CreateUserAsync(User user);
        Task<int> UpdateUserAsync(User user, int id);
        Task<int> DeleteUserAsync(int id);
    }
}