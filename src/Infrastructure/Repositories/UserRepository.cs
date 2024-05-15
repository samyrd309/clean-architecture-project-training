namespace CleanArchitectureImplementation.Infrastructure.Repositories;
using CleanArchitectureImplementation.Domain.Entities;
using CleanArchitectureImplementation.Domain.Repository;
using CleanArchitectureImplementation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUsersRepository
{
    private readonly AppDbContext _usercontext;
    public UserRepository(AppDbContext usercontext)
    {
        _usercontext = usercontext;
    }
    public async Task<User> CreateUserAsync(User user)
    {
        await _usercontext.Users.AddAsync(user);
        await _usercontext.SaveChangesAsync();
        return user;
    }

    public async Task<int> DeleteUserAsync(int id)
    {
        return await _usercontext.Users
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        return await _usercontext.Users.ToListAsync();
    }

    public async Task<User?> GetUserByIdAsync(int userId)
    {

        return await _usercontext.Users
                .Where(model => model.Id == userId)
                .FirstOrDefaultAsync();
    }

    public async Task<int> UpdateUserAsync(User user, int id)
    {
        return await _usercontext.Users
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(model => model.Name, user.Name)
                    .SetProperty(model => model.Email, user.Email)
                    .SetProperty(model => model.Password, user.Password)
                );
    }
}
