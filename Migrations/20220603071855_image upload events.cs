using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class imageuploadevents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c7f8b83-814c-4e70-a6cc-6c3e4fec24d7", "AQAAAAEAACcQAAAAEFgocNSnEl6DrCpbhHPWpa8HxEvJw7D+9X0WVHcjtD/niEwxy+/QKsmQFh/714uLEg==", "c5203f3b-fc9c-4c13-9b43-68dbe1510c2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75cc9d02-0c04-45cb-b4e6-8d5e87feeb77", "AQAAAAEAACcQAAAAENUM1F8x9OhLRvCKiyiUzGaXLtY8u2xzZBbzeSFlBAInJZpNmsYyJ0pYdzBMC3AD4Q==", "7cad10b0-3384-47de-b53d-295eefbe4a70" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 9, 18, 54, 434, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 9, 18, 54, 434, DateTimeKind.Local).AddTicks(2137), new DateTime(2022, 6, 3, 9, 18, 54, 434, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 9, 18, 54, 434, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 9, 18, 54, 434, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 9, 18, 54, 434, DateTimeKind.Local).AddTicks(2061));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b205dcc-a66f-4f6c-b247-42911f8b5b4d", "AQAAAAEAACcQAAAAEAij+ujAuHcWgBnSElVYMSvjbsslIKHnjSjcppgjXBZiI/hgEKk8NNOKwT0z4pHbJg==", "d0ee9d33-4b19-4194-a79f-6beb535b7bb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c498af76-b2d7-42ec-9ffe-d58176b743ee", "AQAAAAEAACcQAAAAECXciUlahiVCJPQPckOphbTE3uNTD6hDyWULeQVTibLWtXm6Xd1b0ANsRNTq71LoDg==", "1afd2dee-dbfb-4723-947d-2f9e80090690" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5318));
        }
    }
}
