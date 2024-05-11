using Microsoft.AspNetCore.Identity;
using TeamHost.Domain.Entities;

namespace TeamHost.Web.Areas.Account.Models
{
    public class UserViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? Patronimic { get; set; }

        public string? About { get; set; }

        public DateTime? Birthday { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public Country? Country { get; set; }

        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
