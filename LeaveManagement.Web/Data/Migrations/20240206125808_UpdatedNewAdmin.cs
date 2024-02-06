using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedNewAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "131b5285-1c4f-443b-83b0-e2c2585da0aa", "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "131b5285-1c4f-443b-83b0-e2c2585da0aa",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed85e470-2bfb-4491-8dab-44e7b90588bd", "SAM@GMAIL.COM", "AQAAAAIAAYagAAAAEA12bpgm+3msnEkAHxBtLWiSXQRJolqmR++P7ANXk3rYSD3PsLl8GmGgzYJN/nu53w==", "6a1806fe-0286-4fc7-9457-77ee8ec2548b" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4c21cef6-5c60-4070-ae6e-c5533a2e4891", 0, "6cad5761-5b96-4d15-9cd6-48a6da214e1a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ragultamilmani823@gmail.com", true, "Ragul", "Tamilmani", false, null, "RAGULTAMILMANI823@GMAIL.COM", "RAGULTAMILMANI823@GMAIL.COM", "AQAAAAIAAYagAAAAEIl0qlEGKljDrKtv+AaLiiE+tsgoxCqbfFDNmb4jyfkfs3yJJnIsoP9hlkpvsT6tCQ==", null, false, "0a6072d3-ba4b-4543-b714-6d93862007f4", null, false, "ragultamilmani@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "131b5285-1c4f-443b-83b0-e2c2585da0aa", "4c21cef6-5c60-4070-ae6e-c5533a2e4891" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "131b5285-1c4f-443b-83b0-e2c2585da0aa", "4c21cef6-5c60-4070-ae6e-c5533a2e4891" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c21cef6-5c60-4070-ae6e-c5533a2e4891");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "131b5285-1c4f-443b-83b0-e2c2585da0aa",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Administartor", "ADMINSTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d651e087-541c-4295-903e-a4a095c2480a", null, "AQAAAAIAAYagAAAAELk9BtkF1Y/lZysA2mKMEoxnlSZbxNiiwO/noaBqNiA6AVJECef1jhwnBnW4ZejQUg==", "6215e78e-7a0f-4002-96ad-f9e6705188bc" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7", 0, "efd1c8b7-301b-45a3-a3f8-6d2e2ca7ece6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ram@gmail.com", true, "Ram", "Kumar", false, null, "RAM@GMAIL.COM", null, "AQAAAAIAAYagAAAAEAWVx3cbOOLRggZyvuWmv/b1q1GQA6mztarMGiqVa1FHTVWM/XfK6eiiZv6kzY67pQ==", null, false, "89891b51-9260-446d-94ef-94941ab1a02e", null, false, "ram@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "131b5285-1c4f-443b-83b0-e2c2585da0aa", "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7" });
        }
    }
}
