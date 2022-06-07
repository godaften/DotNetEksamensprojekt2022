using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class OnlineRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Online",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6eaf38c-a89b-4c74-bb6b-01c48b2118cb", "AQAAAAEAACcQAAAAEPFsj+jQpfDxBfl0mFeoXBf8CaURz1VHUVWu82EMMhS8/hzM+beuH++2EA0xqTK48Q==", "73a8dd61-cc2a-4fff-8177-28a28b358750" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41047201-1949-4f77-a48a-02e335f5de84", "AQAAAAEAACcQAAAAEOW4OyV0/NGtFhKyunZ1BZ4oAMtPCoU+LzvT3BFvqKPjBYo1C5DlvO1FTerkY6tAww==", "330febea-d288-4ecd-9ceb-a933b1fd8251" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8351), new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8356), new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8361), new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8288));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Online",
                table: "Event",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb99d4ab-78dc-4a24-8c2c-adeb928afe77", "AQAAAAEAACcQAAAAECvlMGpE7fzkjPQ2dZTrofbdQcnbIQdAMscgD94WeSm6E8oTT+pLl6zuh/BThYB/6g==", "7341e852-a98d-4a30-af5c-d6bdfb4cf3eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d31816d0-123c-4e82-adaf-2e4d37b8b3b6", "AQAAAAEAACcQAAAAEJKm+wpzU6wn2e4R8r8UGoGo7+Y91kE9cz8I8i6tuvlX+E3L2eO79mVOTUvoPPJ1zQ==", "84650574-9718-42d7-921d-3dfb128d530d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8736), new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8741), new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EventEndDateTime", "EventStartDateTime", "Online" },
                values: new object[] { new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8746), new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8745), true });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8669));
        }
    }
}
