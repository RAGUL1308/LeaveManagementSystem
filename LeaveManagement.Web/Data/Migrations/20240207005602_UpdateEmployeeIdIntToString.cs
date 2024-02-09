using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeIdIntToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c21cef6-5c60-4070-ae6e-c5533a2e4891",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2530c0c2-922e-47b7-ab97-b5e568089082", "AQAAAAIAAYagAAAAEI4ZMNJRCYucfMr8nLmvItDun2b2w0OYh5i4GEejcKCp+b5datGUfcmsMDYSAUnuAw==", "ef8b9ec2-3c44-4b02-aeb3-93336de4efa1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30bd7dfc-376b-47c6-b485-e5788e924e17", "AQAAAAIAAYagAAAAEJexwiWoJ4R2mSbUCS5dPcaaDKDBJ6QMAYvn3HOrLFeqHWc9lNhEl3pIS43dRDGchQ==", "6252b1de-d547-4a11-a64a-667f8a295708" });
        }
    }
}
