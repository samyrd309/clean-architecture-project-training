

namespace CleanArchitectureImplementation.Application.Users.Commands.UpdateUser;

using System.Threading;
using System.Threading.Tasks;
using CleanArchitectureImplementation.Domain.Entities;
using CleanArchitectureImplementation.Domain.Repository;
using MediatR;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, int>
{
    private readonly IUsersRepository _repository;
    public UpdateUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
         var UpdateUserEntity = new User()
        {
            Id = request.Id,
            Name = request.Name,
            Email = request.Email,
            Password = request.Password
        };
        return await _repository.UpdateUserAsync(UpdateUserEntity, request.Id);

    }
}
