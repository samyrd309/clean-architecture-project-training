using CleanArchitectureImplementation.Application.User.Queries.GetUsers;
using MediatR;

namespace CleanArchitectureImplementation.Application.User.Commands.CreateUser;

public class CreateUserCommand : IRequest<UserVm>
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}