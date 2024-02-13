using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestCommentsIntoNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c21cef6-5c60-4070-ae6e-c5533a2e4891",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c199559-e104-4b30-8719-80b7a6dfb024", "AQAAAAIAAYagAAAAEI2L3z0Fze4Acf6P1g37tcJyM0iezUS3yCZ2c4CkoK8ty/673XuAQqf0+V8bjQ983g==", "7ea4b571-3459-42ff-ab69-295d55a65649" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0aa41a49-5f7a-415c-94ad-e87851ec90c0", "AQAAAAIAAYagAAAAEDMpsDseztUEId2M3desXcZ3dQgzZNAp+taDW4IBZyiQLy+Fr9EAY0UvRxKAI5uY+g==", "be5b0478-358a-491b-80d2-8bc38460a262" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c21cef6-5c60-4070-ae6e-c5533a2e4891",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f089b51-9feb-49c0-80d8-fc725d1d8433", "AQAAAAIAAYagAAAAELaWm1LXBQosKLpTefB19qClNV+vk0gEVd9je7GUHBnH5yFiimsDI/JkZHmOoV4YCw==", "9b7286c8-1381-428e-b0a9-fbbc99d20327" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe77bf15-58b0-4a05-abf7-49e46dd7a950",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66174ca2-342f-4368-9867-fe362e3aa618", "AQAAAAIAAYagAAAAENcqgivpzdBQVEK2Q1DsSkymVoVM0UGVeEcHBPRib1MvEcvpz0ozPGgA2X5+R+zuhQ==", "b8516738-395a-48f6-99ab-7836340d8634" });
        }
    }
}
