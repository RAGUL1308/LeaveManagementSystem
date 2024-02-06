using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "4c21cef6-5c60-4070-ae6e-c5533a2e4891",
                     Email = "ragultamilmani823@gmail.com",
                     NormalizedEmail ="RAGULTAMILMANI823@GMAIL.COM",
                     NormalizedUserName="RAGULTAMILMANI823@GMAIL.COM",
                     UserName = "ragultamilmani@gmail.com",
                     FirstName = "Ragul",
                     LastName = "Tamilmani",
                     PasswordHash = hasher.HashPassword(null, "Ragul$1308") ,
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                     Email = "sam@gmail.com",
                     NormalizedEmail = "SAM@GMAIL.COM",
                     NormalizedUserName ="SAM@GMAIL.COM",
                     UserName = "sam@gmail.com",
                     FirstName = "Sam",
                     LastName = "Prasath",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
              );
        }
    }
}