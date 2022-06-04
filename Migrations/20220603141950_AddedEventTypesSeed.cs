using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class AddedEventTypesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c26593-c8aa-49fd-993c-1036bbfd95e3", "AQAAAAEAACcQAAAAEPi0vyxbzI5zsIg7StVSeI7FDjFvs3vT/QtSLC47bbzKVre68vWwMEwF6aPwcq9QRQ==", "4d5d835c-e186-47fe-86b5-704c08ec45a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad0f929-f67b-417d-953d-c4f0211ad644", "AQAAAAEAACcQAAAAEA3RJ6NxWaepBoA/6Zdc7pa+KuacdqhdgD+QIAhO+vYJ5I0BYf/h/5mWVIVryI1SDw==", "69b1b48e-cc59-4a7f-84fb-99d67b4c927c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7148), new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.InsertData(
                table: "EventType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Concert" },
                    { 2, "Comedy" },
                    { 3, "Sport" }
                });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7108));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f22ac179-32a3-45ed-8aed-4e688e4238ac", "AQAAAAEAACcQAAAAEF+zrpKat/6BdSHv0h9v6fyauA5kDB3xiskqb+jK+SbWLQILYFqaKOJkBCKO447O9Q==", "c5db1c04-13d3-491b-ad8f-e6d60d8f1353" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e33fd00-f0da-4cdc-9d92-b9824dfdd0c2", "AQAAAAEAACcQAAAAEAntqQsSq5/amqRjS0mVcG3WTJ2MJG0XX3AO3fw8ggfiTyrCjLsUnRzrNmBFGTg7cQ==", "5cf9aa9e-0d15-4e4c-a1f4-7ace0f514e2b" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 12, 3, 352, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 12, 3, 352, DateTimeKind.Local).AddTicks(8979), new DateTime(2022, 6, 3, 16, 12, 3, 352, DateTimeKind.Local).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 12, 3, 352, DateTimeKind.Local).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 12, 3, 352, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 12, 3, 352, DateTimeKind.Local).AddTicks(8932));
        }
    }
}
