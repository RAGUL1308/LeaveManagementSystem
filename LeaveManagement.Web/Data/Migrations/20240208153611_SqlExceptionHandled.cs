using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SqlExceptionHandled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c21cef6-5c60-4070-ae6e-c5533a2e4891",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "440572e6-2fc5-4acf-8a78-7772bd8ea42c", "AQAAAAIAAYagAAAAEAhww0nu2O7czvfu00VnfLTKAGFWoHF0L9qt+f4xTBYBOpEZlh76Z1frN5XgcIWXyg==", "5f171cfe-2598-427c-804b-4d6c5fac0f3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e97f60a-4cfa-4345-a8ac-778734ea175e", "AQAAAAIAAYagAAAAELt9dooNLga5qqEpw8qXICQMpDfem1pO+YkhP+v1Ly640LN/XwJnY8/EBos2GxiNSw==", "617fe816-c669-41cf-a61f-b195ea3a5e8f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c21cef6-5c60-4070-ae6e-c5533a2e4891",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98a3f93c-e65a-4935-9a30-b07937e88713", "AQAAAAIAAYagAAAAEGxyMcdQLOY6w3PmVFojjBL4mBqGTRe8ikMWV4C0gScP7aJ85Bv/8Byy8QZ+JdI7ZQ==", "1ffe2b3c-b1de-4b4d-ab96-4fb9d75fa6f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cda88ca1-8ee0-4aaa-9683-c207e376496d", "AQAAAAIAAYagAAAAEMc6JSINNmBkDl0mvZvwNhYnoArAvsmHYyTNodJTlWBM15FhIC4y/+WWWkMt9IvU3A==", "79488a95-cfdc-4b3b-82a5-370c36066345" });
        }
    }
}
