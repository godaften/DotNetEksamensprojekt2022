using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class seedposts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cee74e8c-a3c3-4189-bc2a-be0be6d7b1da", "test@kea.dk", "TEST@KEA.DK", "TEST@KEA.DK", "AQAAAAEAACcQAAAAEDs7gSjQZHfzLMg9zDvOE/qddlrhjt+UUGoztBJfdwrHQiHVJPgLDjdGRRlAWK4C/Q==", "da6e7853-de8c-4a0f-88d1-40bea745749b", "test@kea.dk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "756399bd-d0f4-4994-a962-329a832fe72c", "jj@kea.dk", "JJ@KEA.DK", "JJ@KEA.DK", "AQAAAAEAACcQAAAAEA9G2/pImBX1M4KvpYdbz2iup1RnOjJeEN2YJg6601kP5q/jt0JgY41yA92RYfn19Q==", "1deb2a56-81cb-40b6-9476-5d86fc35dce7", "jj@kea.dk" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "361c8fc5-c64e-4e59-8661-1b547e2b6011", "christian@kea.dk", null, null, "AQAAAAEAACcQAAAAEDwSDibeOajyOYJGKjYTkSVv8pfsMG91aIr8w4I7x8SNYVAcyG3OQBaUzfi/DoT7yQ==", "4a82f8ce-19d8-425c-9e53-cdd824d05a96", "christian@kea.dk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "daf611e2-236d-49b9-a739-e36c5c9fe478", "test@kea.dk", null, null, "AQAAAAEAACcQAAAAEOSQAUlj/DhsehBEDDGznyUbHZ1h31cVUVdDyNj+MIQfVFqVzGQFFwoYDiZa21MTaA==", "16e1c8af-a03f-4145-b8af-05f45841cf66", "test@kea.dk" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3", 0, "cc3ed0cf-b2ea-447b-bd18-f9df636b142b", "admin@kea.dk", true, false, null, null, null, "AQAAAAEAACcQAAAAEFGIQrNwKl7a3PNzlMRX6+yUx1Tpgiy1PgvO7zQkc2MpZachlpbVOXFmdUP1CWXJ4g==", null, false, "0cc68118-c95f-4a2b-9a2d-4fe210265c35", false, "admin@kea.dk" },
                    { "5", 0, "2059a637-842d-40dd-9f75-57c047a35efd", "jj@kea.dk", true, false, null, "JJ@KEA.DK", "JJ@KEA.DK", "AQAAAAEAACcQAAAAEGpyFnC2Gjo4BxLdf+UOTkuIaa/5owdtkm+ar3hah712Ic1g0PxeD1tx1pENrn/rcA==", null, false, "76fcc9f7-56b4-4d89-ae91-bd6daeac198c", false, "jj@kea.dk" }
                });
        }
    }
}
