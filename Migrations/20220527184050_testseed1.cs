using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class testseed1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "361c8fc5-c64e-4e59-8661-1b547e2b6011", "christian@kea.dk", "AQAAAAEAACcQAAAAEDwSDibeOajyOYJGKjYTkSVv8pfsMG91aIr8w4I7x8SNYVAcyG3OQBaUzfi/DoT7yQ==", "4a82f8ce-19d8-425c-9e53-cdd824d05a96", "christian@kea.dk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daf611e2-236d-49b9-a739-e36c5c9fe478", "AQAAAAEAACcQAAAAEOSQAUlj/DhsehBEDDGznyUbHZ1h31cVUVdDyNj+MIQfVFqVzGQFFwoYDiZa21MTaA==", "16e1c8af-a03f-4145-b8af-05f45841cf66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc3ed0cf-b2ea-447b-bd18-f9df636b142b", "AQAAAAEAACcQAAAAEFGIQrNwKl7a3PNzlMRX6+yUx1Tpgiy1PgvO7zQkc2MpZachlpbVOXFmdUP1CWXJ4g==", "0cc68118-c95f-4a2b-9a2d-4fe210265c35" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5", 0, "2059a637-842d-40dd-9f75-57c047a35efd", "jj@kea.dk", true, false, null, "JJ@KEA.DK", "JJ@KEA.DK", "AQAAAAEAACcQAAAAEGpyFnC2Gjo4BxLdf+UOTkuIaa/5owdtkm+ar3hah712Ic1g0PxeD1tx1pENrn/rcA==", null, false, "76fcc9f7-56b4-4d89-ae91-bd6daeac198c", false, "jj@kea.dk" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "742dbddd-c784-4ae1-8b4f-1bcd5eee0755", "chrk@kea.dk", "AQAAAAEAACcQAAAAEGkWhdSe6XsG8RA8n5rmOznnMoQpI2zs/M5NKvKf9qZb1MQznBNsn5p4czmPJDE9Qg==", "0ff3daf2-4999-4c21-854e-39993a668b17", "chrk@kea.dk" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f358954-2af5-49f0-bd30-77ad3a522d4f", "AQAAAAEAACcQAAAAEG2nhEDZtlPdfMaIfuUhD1GV6XuNBUp5bgZbw+3kY58WkhwBeuOatIc5r6ah8FeBYw==", "889b76c8-b6f6-49ed-bae2-0e4900655707" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e11361f-1358-42b0-b948-b1730abb783e", "AQAAAAEAACcQAAAAEKjgFCXDQ6p/VgyREwUjDFK7migLnyu7HyROYXtgp3YsrOi7AcaqXYLYC+ZLOsIn6Q==", "d1838a38-2ffa-4f2f-9b88-78f5f2a4f72d" });
        }
    }
}
