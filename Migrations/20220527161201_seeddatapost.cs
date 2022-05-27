using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class seeddatapost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64ca8d4e-8a7e-4682-a627-060ae50f3e8f", "AQAAAAEAACcQAAAAEK+qSrVf9uegFPuC18+fejunh1YzfbWusFZ64JBz8bND8FUO9JzgXvDaoZYeJgUNjg==", "dcee2246-1a11-46a7-b253-c21624fa9ae5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "717de56a-2aea-4b97-a4f9-fd73eddc9676", "AQAAAAEAACcQAAAAENDnUl23oi0XaAYwGRPjGShWMZdwaQTjvij6isKua+T95wYnLI2QI2aUaom8NfrYsw==", "7d23690a-3d4b-4764-8e37-b769dbfdb2a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "433182e4-b253-4d57-9dad-12043634aff4", "AQAAAAEAACcQAAAAEP/iuZrA7wlZAvC6z8vOSBIMTTK64kgXzykpgmFRnYiD8M9xEZA0pNq2nvrX1rgOAw==", "85f1ed59-040a-4b88-bfe7-e86559e04dad" });
        }
    }
}
