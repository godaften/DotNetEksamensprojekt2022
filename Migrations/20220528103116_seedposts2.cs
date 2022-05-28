using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class seedposts2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cee74e8c-a3c3-4189-bc2a-be0be6d7b1da", "AQAAAAEAACcQAAAAEDs7gSjQZHfzLMg9zDvOE/qddlrhjt+UUGoztBJfdwrHQiHVJPgLDjdGRRlAWK4C/Q==", "da6e7853-de8c-4a0f-88d1-40bea745749b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "756399bd-d0f4-4994-a962-329a832fe72c", "AQAAAAEAACcQAAAAEA9G2/pImBX1M4KvpYdbz2iup1RnOjJeEN2YJg6601kP5q/jt0JgY41yA92RYfn19Q==", "1deb2a56-81cb-40b6-9476-5d86fc35dce7" });
        }
    }
}
