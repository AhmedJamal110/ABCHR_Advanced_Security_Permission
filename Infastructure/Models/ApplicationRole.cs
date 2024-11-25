
using Microsoft.AspNetCore.Identity;

namespace Infastructure.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; } = string.Empty;
    }
}
