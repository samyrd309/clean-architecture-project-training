
namespace CleanArchitectureImplementation.Application.Users.Queries.GetUsersById;

using System.Threading;
using AutoMapper;
using CleanArchitectureImplementation.Application.Users.Queries.GetUsersById;
using CleanArchitectureImplementation.Application.Users.Queries.GetUsers;
using CleanArchitectureImplementation.Domain.Repository;
using MediatR;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserVm>
{
    private readonly IUsersRepository _usersRepository;
    private readonly IMapper _mapper;
    public GetUserByIdQueryHandler(IUsersRepository usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }
    public async Task<UserVm> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
       var user = await _usersRepository.GetUserByIdAsync(request.UserId);
       return _mapper.Map<UserVm>(user);
       
    }
}