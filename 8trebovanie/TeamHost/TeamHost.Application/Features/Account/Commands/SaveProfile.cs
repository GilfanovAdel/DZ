using MediatR;

namespace TeamHost.Application.Features.Account.Commands
{
    public class SaveProfile : IRequest<bool>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronimic { get; set; }
        public string About { get; set; }
        public DateTime? Birthday { get; set; }
        public string IdentityUserId { get; set; }
    }
}
