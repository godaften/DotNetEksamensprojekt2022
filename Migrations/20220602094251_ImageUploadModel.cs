using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class ImageUploadModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b205dcc-a66f-4f6c-b247-42911f8b5b4d", "AQAAAAEAACcQAAAAEAij+ujAuHcWgBnSElVYMSvjbsslIKHnjSjcppgjXBZiI/hgEKk8NNOKwT0z4pHbJg==", "d0ee9d33-4b19-4194-a79f-6beb535b7bb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c498af76-b2d7-42ec-9ffe-d58176b743ee", "AQAAAAEAACcQAAAAECXciUlahiVCJPQPckOphbTE3uNTD6hDyWULeQVTibLWtXm6Xd1b0ANsRNTq71LoDg==", "1afd2dee-dbfb-4723-947d-2f9e80090690" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 2, 11, 42, 51, 23, DateTimeKind.Local).AddTicks(5318));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

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
    }
}
