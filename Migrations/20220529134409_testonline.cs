using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class testonline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "580016a2-95b8-4f83-90e7-afafb59b4b30", "AQAAAAEAACcQAAAAEI69JbrG1t34XDFrkahi0xq+iY9GCqW6yRS5QbP3OmRkY69zwpfSttbZL8yPT5wnSw==", "5b4d56b9-d379-4289-ae89-610d30e2e116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c18c18-846b-4cbb-ba51-4c1b30a83f32", "AQAAAAEAACcQAAAAELp6vbDPIhv7PqG6VLQc3N7uX1J94NpeJFO6lUuVYCTXA/moM/6f+A6FNkxil9OsGg==", "c0593dbf-30cb-44f9-94a5-6391aba90475" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 15, 44, 9, 435, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 15, 44, 9, 435, DateTimeKind.Local).AddTicks(2329), new DateTime(2022, 5, 29, 15, 44, 9, 435, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 15, 44, 9, 435, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 15, 44, 9, 435, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 15, 44, 9, 435, DateTimeKind.Local).AddTicks(2279));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
