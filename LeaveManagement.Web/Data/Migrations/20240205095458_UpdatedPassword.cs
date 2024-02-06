using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd1c8b7-301b-45a3-a3f8-6d2e2ca7ece6", "AQAAAAIAAYagAAAAEAWVx3cbOOLRggZyvuWmv/b1q1GQA6mztarMGiqVa1FHTVWM/XfK6eiiZv6kzY67pQ==", "89891b51-9260-446d-94ef-94941ab1a02e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d651e087-541c-4295-903e-a4a095c2480a", "AQAAAAIAAYagAAAAELk9BtkF1Y/lZysA2mKMEoxnlSZbxNiiwO/noaBqNiA6AVJECef1jhwnBnW4ZejQUg==", "6215e78e-7a0f-4002-96ad-f9e6705188bc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b10b74eb-d73f-4e0f-9f4c-b2b7b578fce7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb8cd622-944c-4c56-97cc-a9d007f97156", "AQAAAAIAAYagAAAAEJNYxueJHxjtFNh6XSbyRp71pPNjd5Zlsamri3yaWukXwT+jPtzWkapv6l2JtugXLg==", "1eefc228-1b06-4b2a-a6dc-22a998477800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dc4d09a-586d-43d5-8028-288a3b3c9c01", "AQAAAAIAAYagAAAAEBBJPwdw1d4HPFRjBD7dUv1gQvScVeH0hvvhPmdi4GijHsbIFf3UPTVFCU2ALk38Dw==", "fbb6145c-f58f-48d1-a80c-524c1fa4a1e9" });
        }
    }
}
