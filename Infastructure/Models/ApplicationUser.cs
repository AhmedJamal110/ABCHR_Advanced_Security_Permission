
using Microsoft.AspNetCore.Identity;

namespace Infastructure.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpire { get; set; }
        public bool IsActive { get; set; }
    }
}
