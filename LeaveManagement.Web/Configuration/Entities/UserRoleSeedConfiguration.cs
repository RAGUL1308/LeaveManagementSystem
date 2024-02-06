using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "131b5285-1c4f-443b-83b0-e2c2585da0aa",
                    UserId = "4c21cef6-5c60-4070-ae6e-c5533a2e4891"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "db2c02b1-0962-4360-9b68-ee149ccfba04",
                    UserId = "fe77bf15-58b0-4a05-abf7-49e46dd7a950"

                }
               );
        }
    }
}