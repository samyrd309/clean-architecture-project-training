
namespace CleanArchitectureImplementation.Application.User.Commands.CreateUser;
using AutoMapper;
using CleanArchitectureImplementation.Application.User.Queries.GetUsers;
using CleanArchitectureImplementation.Domain.Entities;
using CleanArchitectureImplementation.Domain.Repository;
using MediatR;


public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserVm>
{
    private readonly IUsersRepository _userRepository;
    private readonly IMapper _mapper;
    public CreateUserCommandHandler(IUsersRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }


    public async Task<UserVm> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var userEntity = new User() {Name = request.Name, Email = request.Email, Password = request.Password};
        var Result = await _userRepository.CreateUserAsync(userEntity);
        return _mapper.Map<UserVm>(Result);

    }
}