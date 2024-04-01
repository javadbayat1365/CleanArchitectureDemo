using Application.User.Commands;

namespace Presentation.Dtos
{
    public class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Email { get; set; }

        public static implicit operator CreateUserCommand(User user)
        {
            return new CreateUserCommand(user.Email,user.Family,user.Email);
        }
    }
}
