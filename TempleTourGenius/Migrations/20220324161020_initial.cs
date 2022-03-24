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
                values: new object[] { new DateTime(2022, 3, 24, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Local), true });

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
                values: new object[] { new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Local), true });

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
                values: new object[] { new DateTime(2022, 3, 24, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 0, 0, 0, DateTimeKind.Local), true });

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
                values: new object[] { new DateTime(2022, 3, 25, 15, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 16, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 25, 18, 0, 0, 0, DateTimeKind.Local), true });

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
                values: new object[] { new DateTime(2022, 3, 26, 12, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 11, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 10, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 26, 9, 0, 0, 0, DateTimeKind.Local), true });

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
                values: new object[] { new DateTime(2022, 3, 25, 17, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.InsertData(
                table: "Timeslots",
                columns: new[] { "Time", "Available" },
                values: new object[] { new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Local), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timeslots");
        }
    }
}
