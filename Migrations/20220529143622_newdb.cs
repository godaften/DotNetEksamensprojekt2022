using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67084f97-e918-4a1f-b23f-c0c77794fc90", "AQAAAAEAACcQAAAAEPc+y0ujPku6pXrRLx0teBnaAHiZXaCHYtj5vG7XRxLjIL695xifaOmE3BzThw1pwg==", "d0f64a96-03d6-4623-bcef-89dfd183ae9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b080d4d9-b0fc-432f-b013-4d7eb70e89a0", "AQAAAAEAACcQAAAAEALcmC6dLtlu/2W0p5sDmek/1h12H7DrzsGLyyodxFvSjJTVKPLYHZY+ykVpODin4Q==", "64645bb1-fc15-41d5-975c-832e5e832a78" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 16, 36, 21, 813, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 16, 36, 21, 813, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 5, 29, 16, 36, 21, 813, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 16, 36, 21, 813, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 16, 36, 21, 813, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 16, 36, 21, 813, DateTimeKind.Local).AddTicks(6348));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
