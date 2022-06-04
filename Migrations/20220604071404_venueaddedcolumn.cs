using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class venueaddedcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeats",
                table: "Venue",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41899120-5b57-4f0e-805c-e2f5060c9bf2", "AQAAAAEAACcQAAAAEJ+SK81n+r0cK4YQkY5i5n+dUZ7NDhgqOi+QtUZAw9f7/pEtrCLaq5HmEmsCeMnSIA==", "023e3f0f-4e73-4346-b5f1-56257ff9b89e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6a2c5e-92b7-4699-9212-c94266d6e08d", "AQAAAAEAACcQAAAAEPzazPJeHNReBg/Nb9XPdSN6L1EMddxzxhTSYmVcnj4+toiRwm8JSgLtTI2ZlZm5Hg==", "a527484a-cbde-4c34-a691-f924cb7fe746" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8502));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfSeats",
                table: "Venue");

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
        }
    }
}
