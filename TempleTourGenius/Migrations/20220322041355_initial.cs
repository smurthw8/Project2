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
                    Time = table.Column<DateTime>(nullable: false),
                    Available = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeslots", x => x.Time);
                });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 21, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 22, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Local), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timeslots");
        }
    }
}
