using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class commentsseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24);

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

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "PostId", "Text", "TimeStamp", "UserId" },
                values: new object[] { 1, 1, "Hello", new DateTime(2022, 5, 29, 12, 7, 4, 871, DateTimeKind.Local).AddTicks(6466), "1" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 22, new DateTime(2022, 5, 29, 12, 4, 1, 131, DateTimeKind.Local).AddTicks(4862), 0, "This is post 2", "Post no 2", null },
                    { 24, new DateTime(2022, 5, 29, 12, 4, 1, 131, DateTimeKind.Local).AddTicks(4865), 0, "This is post 3", "Post no 3", null }
                });
        }
    }
}
