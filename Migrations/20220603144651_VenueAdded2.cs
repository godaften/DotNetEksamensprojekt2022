using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class VenueAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68237ce7-4b81-4614-80ed-0ef45c652d4d", "AQAAAAEAACcQAAAAEHXUBxMX15p2NmSWupnHBOhV+yG/s3XDEcKHMosWX6mPsuIKHVNgPksOpmku1+8isw==", "455b8eb3-d00a-431e-b367-0456688b2e38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4fd0e9-74bb-4d80-9265-ce5505209024", "AQAAAAEAACcQAAAAEDdMg9SsECARS/obqZWqfvQ34hLlCvVQH9mu3wwipZTehh8HFoDdsH7w1pWQKXEPAA==", "c1a056e0-973a-4714-9e9a-0b443d19e046" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 46, 50, 766, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 46, 50, 766, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 6, 3, 16, 46, 50, 766, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 46, 50, 766, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 46, 50, 766, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 46, 50, 766, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Green Stage" },
                    { 2, "Small Room" },
                    { 3, "Hall" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0fa741-8635-4d1b-a20a-7a0c2bda4b40", "AQAAAAEAACcQAAAAEPsWhsK2WRpe6cKqSSaoPEjgSwXWFOENnDhFCdJL/+x/y2MCp4tuxk+C4kiNB+RmhA==", "09f9bdb4-508a-4bbb-ad3a-4e9c4a6de502" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c63bfb4-fa7f-4fa7-861c-0bd20a4c5264", "AQAAAAEAACcQAAAAEJRro8emF1b4x36r1WokLIpQwbTtiQMGU1a+fY+MpNIeF0YDT9BgHMqn9oUmz68XbQ==", "10c61aad-d256-4c90-869c-6ed892ceec0e" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6379));
        }
    }
}
