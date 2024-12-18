﻿
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Configrations
{
    public class ApplicationUserRoleConfigration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder
                .ToTable("UserRoles", SchemaConfigration.Security);
        }
    }
}
