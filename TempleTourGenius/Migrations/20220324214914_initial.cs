using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleTourGenius.Migrations
{
    public partial class initial : Migration
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
                values: new object[] { 1, true, new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 66, true, new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 65, true, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 64, true, new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 63, true, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 62, true, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 61, true, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 60, true, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 59, true, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 58, true, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 57, true, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 56, true, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 55, true, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 54, true, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 53, true, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 52, true, new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 51, true, new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 50, true, new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 49, true, new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 48, true, new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 67, true, new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 47, true, new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 68, true, new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 70, true, new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 89, true, new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 88, true, new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 87, true, new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 86, true, new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 85, true, new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 84, true, new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 83, true, new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 82, true, new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 81, true, new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 80, true, new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 79, true, new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 78, true, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 77, true, new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 76, true, new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 75, true, new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 74, true, new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 73, true, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 72, true, new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 71, true, new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 69, true, new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 90, true, new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 46, true, new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 44, true, new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 20, true, new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 19, true, new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 18, true, new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 17, true, new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 16, true, new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 15, true, new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 14, true, new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 13, true, new DateTime(2022, 3, 24, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 12, true, new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 11, true, new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 10, true, new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 9, true, new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 8, true, new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 7, true, new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 6, true, new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 5, true, new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 4, true, new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 3, true, new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 2, true, new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 21, true, new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 45, true, new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 22, true, new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 24, true, new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 43, true, new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 42, true, new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 41, true, new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 40, true, new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 39, true, new DateTime(2022, 3, 26, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 38, true, new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 37, true, new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 36, true, new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 35, true, new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 34, true, new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 33, true, new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 32, true, new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 31, true, new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 30, true, new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 29, true, new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 28, true, new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 27, true, new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 26, true, new DateTime(2022, 3, 25, 20, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 25, true, new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "TimeId", "Available", "Time" },
                values: new object[] { 23, true, new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Local) });

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
