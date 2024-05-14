using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace CleanArchitectureImplementation.Application.User.Queries.GetUsers;
public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<UserVm>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUsersQueryHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }


    public async Task<List<UserVm>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllUsers();
        var userList = _mapper.Map<List<UserVm>>(users);

        return userList;
    }
}