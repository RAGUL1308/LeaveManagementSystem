using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
