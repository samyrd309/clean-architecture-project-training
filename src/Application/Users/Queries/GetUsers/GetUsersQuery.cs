using MediatR;

namespace CleanArchitectureImplementation.Application.User.Queries.GetUsers;
public record GetUsersQuery : IRequest<List<UserVm>>
{

}