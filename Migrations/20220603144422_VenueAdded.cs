using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class VenueAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventGenre",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VenueId",
                table: "Event",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0fa741-8635-4d1b-a20a-7a0c2bda4b40", "AQAAAAEAACcQAAAAEPsWhsK2WRpe6cKqSSaoPEjgSwXWFOENnDhFCdJL/+x/y2MCp4tuxk+C4kiNB+RmhA==", "09f9bdb4-508a-4bbb-ad3a-4e9c4a6de502" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c63bfb4-fa7f-4fa7-861c-0bd20a4c5264", "AQAAAAEAACcQAAAAEJRro8emF1b4x36r1WokLIpQwbTtiQMGU1a+fY+MpNIeF0YDT9BgHMqn9oUmz68XbQ==", "10c61aad-d256-4c90-869c-6ed892ceec0e" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 44, 22, 63, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.CreateIndex(
                name: "IX_Event_VenueId",
                table: "Event",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event");

            migrationBuilder.DropTable(
                name: "Venue");

            migrationBuilder.DropIndex(
                name: "IX_Event_VenueId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "EventGenre",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "VenueId",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c26593-c8aa-49fd-993c-1036bbfd95e3", "AQAAAAEAACcQAAAAEPi0vyxbzI5zsIg7StVSeI7FDjFvs3vT/QtSLC47bbzKVre68vWwMEwF6aPwcq9QRQ==", "4d5d835c-e186-47fe-86b5-704c08ec45a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad0f929-f67b-417d-953d-c4f0211ad644", "AQAAAAEAACcQAAAAEA3RJ6NxWaepBoA/6Zdc7pa+KuacdqhdgD+QIAhO+vYJ5I0BYf/h/5mWVIVryI1SDw==", "69b1b48e-cc59-4a7f-84fb-99d67b4c927c" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7148), new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 3, 16, 19, 50, 231, DateTimeKind.Local).AddTicks(7108));
        }
    }
}
