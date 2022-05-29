using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class eventtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventType",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43c9fdd2-c6ad-4a54-962a-8c080fd6cc9e", "AQAAAAEAACcQAAAAENUvCXhc5wc7bmmHe8uo+LhjYONOksNi8oBBqwf6wjw3rgBgE+VA2TAs+Y8feauNoQ==", "3e7fde88-8aeb-4f00-a8c4-31fb0a93047c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e296e2b5-4b2e-4c5c-95ea-e10741f70c04", "AQAAAAEAACcQAAAAEAjlXX1eAanct2g/22R9EOaA6qPdNjsjODazuNFwqlpi/3LwwOdKuADo/wLbeeJafw==", "eea8d443-9cd1-492b-b1ac-2109aa0e5b1f" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 16, 33, 53, 225, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 33, 53, 225, DateTimeKind.Local).AddTicks(2543), new DateTime(2022, 5, 29, 16, 33, 53, 225, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 16, 33, 53, 225, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 16, 33, 53, 225, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 16, 33, 53, 225, DateTimeKind.Local).AddTicks(2494));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventType",
                table: "Event");

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
    }
}
