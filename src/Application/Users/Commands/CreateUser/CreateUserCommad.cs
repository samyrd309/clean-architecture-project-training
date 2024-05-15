using CleanArchitectureImplementation.Application.Users.Queries.GetUsers;
using MediatR;

namespace CleanArchitectureImplementation.Application.Users.Commands.CreateUser;

public class CreateUserCommand : IRequest<UserVm>
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}