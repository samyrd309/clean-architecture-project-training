
namespace CleanArchitectureImplementation.Application.User.Queries.GetUsersById;

using System.Threading;
using CleanArchitectureImplementation.Application.User.Queries.GetUsers;
using MediatR;

public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserVm>
{
    public Task<UserVm> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}