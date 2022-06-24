using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "ec8bbadf-6667-47bf-6969-de5fca8667fb",
                    UserId = "ec8bbadf-65f4-47bf-ba86-de5fca8667fb"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "ec8bbadf-6667-47bf-6969-aaaaca8667fb",
                    UserId = "ec8bbadf-65f4-ffff-ba86-de5fca8667fb"
                }
            );
        }
    }
}