using CleanArchitectureImplementation.Application.User.Queries.GetUsers;
using MediatR;

namespace CleanArchitectureImplementation.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        
    }
}