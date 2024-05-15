using CleanArchitectureImplementation.Domain.Repository;
using MediatR;

namespace CleanArchitectureImplementation.Application.Users.Commands.DeleteUser;

public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, int>
{
    private readonly IUsersRepository _repository;
    public DeleteUserCommandHandler(IUsersRepository repository)
    {
        _repository = repository;
    }
    public async Task<int> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        return await _repository.DeleteUserAsync(request.Id);
    }
}
