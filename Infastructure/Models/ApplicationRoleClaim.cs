﻿
using Microsoft.AspNetCore.Identity;

namespace Infastructure.Models
{
    public class ApplicationRoleClaim : IdentityRoleClaim<string>
    {
        public string Description { get; set; } = string.Empty;
        public string Group { get; set; } = string.Empty;

    }
}
