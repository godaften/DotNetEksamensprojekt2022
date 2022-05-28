using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class newuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "742dbddd-c784-4ae1-8b4f-1bcd5eee0755", "AQAAAAEAACcQAAAAEGkWhdSe6XsG8RA8n5rmOznnMoQpI2zs/M5NKvKf9qZb1MQznBNsn5p4czmPJDE9Qg==", "0ff3daf2-4999-4c21-854e-39993a668b17" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4e5ca95-fc4b-49e5-b7cf-9e36ee2da0db", "AQAAAAEAACcQAAAAEGcscSoX+Px+7syPhlaEfIfdMTwuSm6oo8Zqx09yIhGiZ2ulF2tdLlZ/+SJ5dEOOhA==", "f62473ff-fec2-4888-8589-7fe9ab28e264" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f77d1433-5b55-4433-b9f8-a8811d78ad51", "AQAAAAEAACcQAAAAENl+0CBbZqYlOHRlFORhunu24QTTsrPykHGs6rC2ll2z4Zeb05VxG/3WRx04uO3mOw==", "e24cdff1-b5c2-4311-abfc-afdb87384ff9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4fce4153-fd61-4fa4-93d3-73cf7bd02ce9", "AQAAAAEAACcQAAAAEJ/fRpr+hYVZaSkFMg7hcHrd4NMQm9pbYlOWwoiX6/Ki487EM/OmKpudmqfhD0yC+g==", "de2eebb8-0bbe-4a67-b448-967f8f708dd2" });
        }
    }
}
