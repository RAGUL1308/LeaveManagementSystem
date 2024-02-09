using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c21cef6-5c60-4070-ae6e-c5533a2e4891",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cad5761-5b96-4d15-9cd6-48a6da214e1a", "AQAAAAIAAYagAAAAEIl0qlEGKljDrKtv+AaLiiE+tsgoxCqbfFDNmb4jyfkfs3yJJnIsoP9hlkpvsT6tCQ==", "0a6072d3-ba4b-4543-b714-6d93862007f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed85e470-2bfb-4491-8dab-44e7b90588bd", "AQAAAAIAAYagAAAAEA12bpgm+3msnEkAHxBtLWiSXQRJolqmR++P7ANXk3rYSD3PsLl8GmGgzYJN/nu53w==", "6a1806fe-0286-4fc7-9457-77ee8ec2548b" });
        }
    }
}
