using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class seedpost4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad09b935-a128-4d36-b595-a5e5742f059b", "AQAAAAEAACcQAAAAEEweKKsJGm/27aAzKyFanEC+keEEszDdw2UaxAi3JmQh5+m6MqodiHUb2hVN7iZAvw==", "9769ae78-b8d8-4367-8d2b-d9beff64415f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acf51620-bf0f-4759-9de5-0ef10e4e8b2e", "AQAAAAEAACcQAAAAELFWRVbLhAiYwcWpJwfEKgEtmK4tiBDEzqSFPVF6dr1n1UdCmdJEwmwe024xmFHLDQ==", "23b549fe-bd76-4c3b-a9b7-726ce2f8d8e4" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 34, 9, 769, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 34, 9, 769, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 34, 9, 769, DateTimeKind.Local).AddTicks(5341));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd9c5f0a-f8bf-4b51-b094-addb00b7277c", "AQAAAAEAACcQAAAAELEUMwYRQ29TmSbFlRHt7v0LolpA5WlZ2pvCT4+TjLTg2qAGh5DL/rXwl4A5DcCUaQ==", "52545941-3268-4263-b760-199e7f3b06b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b6f6cbd-2311-4791-8628-a10a8c1e50cd", "AQAAAAEAACcQAAAAEJNNsyxzG0IoxyKkToUw593sJ/NRIm8hGBKglrfb6qI6asx6tx1h6kh86zpV0xC/aQ==", "eaa1d634-19c9-4d64-bbe8-b8202d0baa11" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 32, 29, 624, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 32, 29, 624, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 32, 29, 624, DateTimeKind.Local).AddTicks(970));
        }
    }
}
