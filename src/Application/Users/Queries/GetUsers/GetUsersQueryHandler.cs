using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using CleanArchitectureImplementation.Domain.Repository;
using MediatR;

namespace CleanArchitectureImplementation.Application.User.Queries.GetUsers;
public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<UserVm>>
{
    private readonly IUsersRepository _userRepository;
    private readonly IMapper _mapper;

    public GetUsersQueryHandler(IUsersRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }


    public async Task<List<UserVm>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllUsersAsync();
        var userList = _mapper.Map<List<UserVm>>(users);

        return userList;
    }
}