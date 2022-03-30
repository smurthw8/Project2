using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTourGenius.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Timeslots",
                columns: table => new
                {
                    TimeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Time = table.Column<DateTime>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeslots", x => x.TimeId);
                });

            migrationBuilder.CreateTable(
                name: "TourInfo",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeId = table.Column<int>(nullable: false),
                    TimeSlotTimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourInfo", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_TourInfo_Timeslots_TimeSlotTimeId",
                        column: x => x.TimeSlotTimeId,
                        principalTable: "Timeslots",
                        principalColumn: "TimeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 1, true, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 66, true, new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 65, true, new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 64, true, new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 63, true, new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 62, true, new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 61, true, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 60, true, new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 59, true, new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 58, true, new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 57, true, new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 56, true, new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 55, true, new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 54, true, new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 53, true, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 52, true, new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 51, true, new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 50, true, new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 49, true, new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 48, true, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 67, true, new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 47, true, new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 68, true, new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 70, true, new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 89, true, new DateTime(2022, 4, 4, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 88, true, new DateTime(2022, 4, 4, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 87, true, new DateTime(2022, 4, 4, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 86, true, new DateTime(2022, 4, 4, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 85, true, new DateTime(2022, 4, 4, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 84, true, new DateTime(2022, 4, 4, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 83, true, new DateTime(2022, 4, 4, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 82, true, new DateTime(2022, 4, 4, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 81, true, new DateTime(2022, 4, 4, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 80, true, new DateTime(2022, 4, 4, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 79, true, new DateTime(2022, 4, 4, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 78, true, new DateTime(2022, 4, 4, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 77, true, new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 76, true, new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 75, true, new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 74, true, new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 73, true, new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 72, true, new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 71, true, new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 69, true, new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 90, true, new DateTime(2022, 4, 4, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 46, true, new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 44, true, new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 20, true, new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 19, true, new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 18, true, new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 17, true, new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 16, true, new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 15, true, new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 14, true, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 13, true, new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 12, true, new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 11, true, new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 10, true, new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 9, true, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 8, true, new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 7, true, new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 6, true, new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 5, true, new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 4, true, new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 3, true, new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 2, true, new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 21, true, new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 45, true, new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 22, true, new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 24, true, new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 43, true, new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 42, true, new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 41, true, new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 40, true, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 39, true, new DateTime(2022, 3, 31, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 38, true, new DateTime(2022, 3, 31, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 37, true, new DateTime(2022, 3, 31, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 36, true, new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 35, true, new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 34, true, new DateTime(2022, 3, 31, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 33, true, new DateTime(2022, 3, 31, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 32, true, new DateTime(2022, 3, 31, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 31, true, new DateTime(2022, 3, 31, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 30, true, new DateTime(2022, 3, 31, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 29, true, new DateTime(2022, 3, 31, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 28, true, new DateTime(2022, 3, 31, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 27, true, new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 26, true, new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 25, true, new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 23, true, new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "TourInfo",
                columns: new[] { "TourId", "Email", "GroupName", "GroupSize", "Phone", "TimeId", "TimeSlotTimeId" },
                values: new object[] { 1, "testnderson@test.com", "Andersons", 5, "8015551234", 1, null });

            migrationBuilder.CreateIndex(
                name: "IX_TourInfo_TimeSlotTimeId",
                table: "TourInfo",
                column: "TimeSlotTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TourInfo");

            migrationBuilder.DropTable(
                name: "Timeslots");
        }
    }
}
