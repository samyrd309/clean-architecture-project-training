using CleanArchitectureImplementation.Application.Users.Queries.GetUsers;
using MediatR;

namespace CleanArchitectureImplementation.Application.User.Queries.GetUsers;
public record GetUsersQuery : IRequest<List<UserVm>>
{

}