using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class EventAdressFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b843c351-630b-40d5-8631-e72be1a0e31c", "AQAAAAEAACcQAAAAEFEROa4YL6x+ugZ+x2nAf3I2NdlYtW+XG+93pv/YGK/fcduaXqmmPCpZDcydcGDQ6A==", "86127eb9-bfd5-4886-a788-5a51a75e48ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4f98409-e5f4-4b76-9d0a-01bb535aa91c", "AQAAAAEAACcQAAAAEHfqu+B9tZWKMwVxH7zjnroonpd3pVfLb48amKnNoo7Aqf/pE5yUO8gTPOEo9KrEtQ==", "abc9fd4d-a234-4c72-9afd-9304b5277412" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 14, 10, 32, 413, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 14, 10, 32, 413, DateTimeKind.Local).AddTicks(5967), new DateTime(2022, 5, 29, 14, 10, 32, 413, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 14, 10, 32, 413, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 14, 10, 32, 413, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 14, 10, 32, 413, DateTimeKind.Local).AddTicks(5920));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
