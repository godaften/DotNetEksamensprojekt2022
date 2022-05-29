using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class onlineeventbool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2fffe78e-e3bf-4277-848b-0c53758b6596", "AQAAAAEAACcQAAAAEPqPDWd9awH3ig7OZiZ2BvxEIqJWAY5iAbJc29byiWVL6tpbJvpPO9IGqkdmNDogdA==", "642adadd-b7e2-4128-bf3e-5518e3ee75a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bc49d48-05b2-46ef-92de-69b24c535c50", "AQAAAAEAACcQAAAAEGPS/HYg9xjPpnWbwE754rBcoLjd3x+8X7grdRsASs1OMKp27yr/r6/8riB4JzzFXA==", "9227563a-229a-4214-8fb6-a15a4063bd84" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 13, 23, 55, 59, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 13, 23, 55, 59, DateTimeKind.Local).AddTicks(1484), new DateTime(2022, 5, 29, 13, 23, 55, 59, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 13, 23, 55, 59, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 13, 23, 55, 59, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 13, 23, 55, 59, DateTimeKind.Local).AddTicks(1401));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Online",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e31e7641-f1af-4ea9-bb6e-e423b9cd11a0", "AQAAAAEAACcQAAAAEHGzCnW+0FtQH2bq4YTPSF/xXr9vX6Z1fCbgx0J/kqQnHpCFRpV0ePBl/rfd92qs8g==", "8e8f2933-4236-4bb7-a55f-68db76642f78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fa9a09f-d8f1-424c-8910-b961884eb2e2", "AQAAAAEAACcQAAAAENqUOwBemqqv+khOPK15+hFaNQw0+RuNRVuO6n3jl6lDDHAcg1e508rLnK7/jUpCsw==", "8e393503-20e0-43fe-ad5e-02de4e404926" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3659), new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3586));
        }
    }
}
