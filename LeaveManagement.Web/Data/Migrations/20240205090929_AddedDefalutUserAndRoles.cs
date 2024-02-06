using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefalutUserAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "131b5285-1c4f-443b-83b0-e2c2585da0aa", null, "Administartor", "ADMINSTRATOR" },
                    { "db2c02b1-0962-4360-9b68-ee149ccfba04", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7", 0, "cb8cd622-944c-4c56-97cc-a9d007f97156", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ram@gmail.com", true, "Ram", "Kumar", false, null, "RAM@GMAIL.COM", null, "AQAAAAIAAYagAAAAEJNYxueJHxjtFNh6XSbyRp71pPNjd5Zlsamri3yaWukXwT+jPtzWkapv6l2JtugXLg==", null, false, "1eefc228-1b06-4b2a-a6dc-22a998477800", null, false, "ram@gmail.com" },
                    { "fe77bf15-58b0-4a05-abf7-49e46dd7a950", 0, "8dc4d09a-586d-43d5-8028-288a3b3c9c01", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam@gmail.com", true, "Sam", "Prasath", false, null, "SAM@GMAIL.COM", null, "AQAAAAIAAYagAAAAEBBJPwdw1d4HPFRjBD7dUv1gQvScVeH0hvvhPmdi4GijHsbIFf3UPTVFCU2ALk38Dw==", null, false, "fbb6145c-f58f-48d1-a80c-524c1fa4a1e9", null, false, "sam@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "131b5285-1c4f-443b-83b0-e2c2585da0aa", "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7" },
                    { "db2c02b1-0962-4360-9b68-ee149ccfba04", "fe77bf15-58b0-4a05-abf7-49e46dd7a950" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "131b5285-1c4f-443b-83b0-e2c2585da0aa", "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "db2c02b1-0962-4360-9b68-ee149ccfba04", "fe77bf15-58b0-4a05-abf7-49e46dd7a950" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "131b5285-1c4f-443b-83b0-e2c2585da0aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db2c02b1-0962-4360-9b68-ee149ccfba04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950");
        }
    }
}
