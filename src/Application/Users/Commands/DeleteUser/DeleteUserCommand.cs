namespace CleanArchitectureImplementation.Application.Users.Commands.DeleteUser
{
    using MediatR;

    public class DeleteUserCommand : IRequest<int>
    {
        public int Id { get; set; } 
    }
}