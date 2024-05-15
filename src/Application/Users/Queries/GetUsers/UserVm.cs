namespace CleanArchitectureImplementation.Application.Users.Queries.GetUsers;
using CleanArchitectureImplementation.Application.Common.Mappings;
using CleanArchitectureImplementation.Domain.Entities;
public class UserVm : IMapFrom<User>
{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
}