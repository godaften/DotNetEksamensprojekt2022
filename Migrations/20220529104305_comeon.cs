using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class comeon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376e63b1-2e02-4a66-94da-b50601061364", "AQAAAAEAACcQAAAAEMSFMjy02/bkFFqdVxAaq8X18LXxNzNXgvA4G40kfsN0v8EfKtqkFIAuz6K5Q5t9+A==", "aff75d40-80d4-4125-a07a-0b67fc614fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4edcdcb-e981-42ed-b861-8b4cef89750e", "AQAAAAEAACcQAAAAEK2JB17WPKgnPCwccqhWlEfWgEJU5feBGO8WPTr/yhEysRKq3CHPHa6kxGv6dUjYMA==", "39a9c126-17b7-4e79-a8b7-dc05a0fafc91" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5533), new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 22, new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5474), 0, "This is post 2", "Post no 2", null },
                    { 24, new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5477), 0, "This is post 3", "Post no 3", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cccc20e-602b-49ac-8043-31b5e5532696", "AQAAAAEAACcQAAAAEDZFU6BYSHglrGaoZrmE1blGR1nFqRK8Qi/Y9wEK71YA3SDowwx3hJU0S6KlJn6VOw==", "2a9f81e3-266f-402e-b633-b4167d3c5690" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52ea6444-ab8d-4c82-a2c5-d03a07d7d0b5", "AQAAAAEAACcQAAAAEHgRwR9wWXtger4ikqqji5x9mk5cy2nNqwpRV8NCue9o2JeTaUUtWoEfpzjDbocALg==", "6496e17e-333d-4525-99b2-d804e1127447" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 12, 7, 4, 871, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 12, 7, 4, 871, DateTimeKind.Local).AddTicks(6486), new DateTime(2022, 5, 29, 12, 7, 4, 871, DateTimeKind.Local).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 7, 4, 871, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 5, 29, 12, 7, 4, 871, DateTimeKind.Local).AddTicks(6436), 0, "This is post 2", "Post no 2", null },
                    { 3, new DateTime(2022, 5, 29, 12, 7, 4, 871, DateTimeKind.Local).AddTicks(6438), 0, "This is post 3", "Post no 3", null }
                });
        }
    }
}
