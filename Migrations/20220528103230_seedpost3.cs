using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class seedpost3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 11, new DateTime(2022, 5, 28, 12, 32, 29, 624, DateTimeKind.Local).AddTicks(928), 0, "This is post 1", "Post no 1", null },
                    { 12, new DateTime(2022, 5, 28, 12, 32, 29, 624, DateTimeKind.Local).AddTicks(967), 0, "This is post 2", "Post no 2", null },
                    { 13, new DateTime(2022, 5, 28, 12, 32, 29, 624, DateTimeKind.Local).AddTicks(970), 0, "This is post 3", "Post no 3", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a305599-3b9f-4e5d-9539-f77e7ac2aff7", "AQAAAAEAACcQAAAAEBuwSXPRFrN6V4Om3v/tqgVvtCS1eVEa7LoErxVy3qVJ4I5alT4IxQzYhYQtLeC1IA==", "4e137658-7157-4f30-9794-33538a355f15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb1e8745-c056-4936-b3a3-90ba17086ed4", "AQAAAAEAACcQAAAAEPPEu+LARb6BUDn/+TOg6ywf5W0AHOppNUSVyDpgyceqSw7PZm/Z3rnjS1rHMee2mA==", "a9719136-4aa5-4c52-b4b3-5743bcabe228" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 28, 12, 31, 15, 808, DateTimeKind.Local).AddTicks(1250), 0, "This is post 1", "Post no 1", null },
                    { 2, new DateTime(2022, 5, 28, 12, 31, 15, 808, DateTimeKind.Local).AddTicks(1302), 0, "This is post 2", "Post no 2", null },
                    { 3, new DateTime(2022, 5, 28, 12, 31, 15, 808, DateTimeKind.Local).AddTicks(1309), 0, "This is post 3", "Post no 3", null }
                });
        }
    }
}
