using System.Security.Cryptography.X509Certificates;
using Domain.Interfaces;
using MediatR;

namespace CleanArchitectureImplementation.Application.User.Queries.GetUsers;
public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<UserVm>>
{
    private readonly IUserRepository _userRepository;

    public GetUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }


    public async Task<List<UserVm>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllUsers();
        var usersList =  users.Select(x=> new UserVm
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Password = x.Password
            }).ToList();

        return usersList;
    }
}