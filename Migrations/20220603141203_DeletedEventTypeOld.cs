using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class DeletedEventTypeOld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventTypeOld",
                table: "Event");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventTypeOld",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
