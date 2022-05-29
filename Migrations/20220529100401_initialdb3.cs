using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class initialdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4805713-8e8e-40b4-8040-30a2d1e525af", "AQAAAAEAACcQAAAAEDRBA9NRMAhUWSdEVu41cMgINSPFGB5z+g3rqQtfVU7EvLzUoW3sEoBROmeE50nsRw==", "6da62423-4014-4f8c-a1eb-1a43c97000f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3a30a95-9607-404f-a13e-d342aae49e6f", "AQAAAAEAACcQAAAAEC0P+ekUV5lgj/T1+oTaFpm+yLJkww1bmVvLjuvmMIpH6v2tuVJIhHaKgFMkgaxp3w==", "6de075c0-9f33-49cd-80d1-465666b5b1a5" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 12, 4, 1, 131, DateTimeKind.Local).AddTicks(4894), new DateTime(2022, 5, 29, 12, 4, 1, 131, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 4, 1, 131, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 4, 1, 131, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 4, 1, 131, DateTimeKind.Local).AddTicks(4865));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80d1f910-6f18-405e-8c49-0a998b67b873", "AQAAAAEAACcQAAAAEIRKmcmCL9ujfEknQXvKjGI58UtMQu12y8XP8MzitiZo1kSpBaA0eRek1eoSyf3Hgw==", "83b56c8c-5f88-4902-9b62-da0beb792f67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3078d35-52b2-4876-b23f-1105cf6f2959", "AQAAAAEAACcQAAAAEChGtOSNCjEcjEEzfQWzPFwOFpP6iEoWJnSQPzxw2TqimHksqHR1GuxfMRIvGvUToA==", "6de82999-72a0-48d8-bfe6-dbea8b5e00cf" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 12, 1, 39, 374, DateTimeKind.Local).AddTicks(8021), new DateTime(2022, 5, 29, 12, 1, 39, 374, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 1, 39, 374, DateTimeKind.Local).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 1, 39, 374, DateTimeKind.Local).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 1, 39, 374, DateTimeKind.Local).AddTicks(7996));
        }
    }
}
