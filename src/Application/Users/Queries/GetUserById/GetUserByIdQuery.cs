using CleanArchitectureImplementation.Application.User.Queries.GetUsers;
using MediatR;

namespace CleanArchitectureImplementation.Application.User.Queries.GetUsersById;

public class GetUserByIdQuery : IRequest<UserVm>
{
    public int UserId { get; set; }
}