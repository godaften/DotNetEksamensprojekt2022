using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class Db11Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75082855-b727-4a17-8c5a-568f2adb33a6", "AQAAAAEAACcQAAAAEGjIE0Nc70U48GoqxBiDCAZwC2Sc8qK8EPMV7DssfTjMdCR/CwI1iZM4TArhOLAi/w==", "2e57597d-11fa-4d0e-b408-186b4424527d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1252ef7c-adfb-4b4b-ab33-84a6ddddb76c", "AQAAAAEAACcQAAAAEMGRyDjANZ+hYykVbhx6UZMo8OiPU9Es3mtFyAKVqO/Fqqpxpt7BXI2PQ/dioW7sjw==", "4b46b786-5150-4353-9cab-7ff7e88b86ce" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 10, 25, 102, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 10, 25, 102, DateTimeKind.Local).AddTicks(4117), new DateTime(2022, 6, 3, 16, 10, 25, 102, DateTimeKind.Local).AddTicks(4115) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 10, 25, 102, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 10, 25, 102, DateTimeKind.Local).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 10, 25, 102, DateTimeKind.Local).AddTicks(4068));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce23166e-4bc2-45e8-85c5-aaecb5fddee7", "AQAAAAEAACcQAAAAEPfN8VmwNbFACYsZSqvxsM1uCchfF9THSggvJ7/3G6CK5hUiy4mU3dlWctFmzAi/1w==", "c376128a-10d5-410b-b210-0631dea3781f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "006bfe9d-bc5a-470b-b875-f3059f9edf05", "AQAAAAEAACcQAAAAELteOhJtEwgyavjc2elOui6IGW0IHp6d7oCEdF1lbGns1aHS7lOGfHkhvjzJNWoV9Q==", "91eedf33-a898-4844-bb5f-7e146ead079d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 9, 33, 678, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 9, 33, 678, DateTimeKind.Local).AddTicks(468), new DateTime(2022, 6, 3, 16, 9, 33, 678, DateTimeKind.Local).AddTicks(465) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 9, 33, 678, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 9, 33, 678, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 9, 33, 678, DateTimeKind.Local).AddTicks(421));
        }
    }
}
