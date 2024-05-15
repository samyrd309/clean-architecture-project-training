using CleanArchitectureImplementation.Application.Users.Queries.GetUsers;
using MediatR;

namespace CleanArchitectureImplementation.Application.Users.Queries.GetUsersById;

public class GetUserByIdQuery : IRequest<UserVm>
{
    public int UserId { get; set; }
}