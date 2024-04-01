using MediatR;

namespace Application.User.Commands;

public record CreateUserCommand(string Name, string Family, string Email) :IRequest<bool>;
