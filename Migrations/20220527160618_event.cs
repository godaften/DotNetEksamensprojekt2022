using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class @event : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "going on", "Party" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "916501f5-0c8d-4d6c-82ec-13580cf0e94a", "AQAAAAEAACcQAAAAEAL8SlBMhZzrZ051JIFy49f9+hFmlUzO2vVoMnU5rogaJxVt0K2OPrkmAIH+PspVZQ==", "e926e61b-2827-45fd-85b0-78c6d14db352" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ef19818-15e2-480d-9549-ccdd5e71bfff", "AQAAAAEAACcQAAAAEGIzEeJlWdqSsX8IMtYb1+N0gGZzE0brCDe/zMiC2QBdRbxp23b+w7C5Db3U2oXlDA==", "23e167da-6fb4-4d41-be33-27a2ac73805a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6572c24c-6f11-4b49-8cce-607635f8a1e9", "AQAAAAEAACcQAAAAEHlSFyKSwnvUNgZmhzCTF/VKJVR/0i+wmjRJ0JoaLLWmRdaKbX6vGLcxMr7dsH6IQA==", "8abac685-9457-4a6a-9064-a651fd447ab8" });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[] { 1, null, null, null, "Party", null });
        }
    }
}
