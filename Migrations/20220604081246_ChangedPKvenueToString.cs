using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class ChangedPKvenueToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venue",
                table: "Venue");

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Venue");

            migrationBuilder.AddColumn<string>(
                name: "VenueId",
                table: "Venue",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "VenueId",
                table: "Event",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venue",
                table: "Venue",
                column: "VenueId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e66be08-223f-49ce-bd07-3943e0ed28c2", "AQAAAAEAACcQAAAAELg4vXH6zLfPO/b2DK+wi82aTGzORNQyWcfH5V0h4cye3Qj+cTBfDvmsIczC7N3+fg==", "8dd5b7be-3be2-490b-8b7f-4c03cf0cb083" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd8d68dd-d2d8-413f-9837-96f9a5ccba26", "AQAAAAEAACcQAAAAEN1iyWGNR7n0gaMkCxY2FwLxvdlzypYSBkap110v91gVp3Xux503w4flWGOO8K8/CQ==", "cb86939a-ceab-4963-a3cd-5c0c4beb8c15" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 4, 10, 12, 45, 660, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 4, 10, 12, 45, 660, DateTimeKind.Local).AddTicks(2832), new DateTime(2022, 6, 4, 10, 12, 45, 660, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 4, 10, 12, 45, 660, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 4, 10, 12, 45, 660, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 4, 10, 12, 45, 660, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Name", "NumberOfSeats" },
                values: new object[,]
                {
                    { "1", "Green Stage", 0 },
                    { "2", "Small Room", 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venue",
                table: "Venue");

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyColumnType: "nvarchar(450)",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyColumnType: "nvarchar(450)",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "VenueId",
                table: "Venue");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Venue",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "VenueId",
                table: "Event",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venue",
                table: "Venue",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41899120-5b57-4f0e-805c-e2f5060c9bf2", "AQAAAAEAACcQAAAAEJ+SK81n+r0cK4YQkY5i5n+dUZ7NDhgqOi+QtUZAw9f7/pEtrCLaq5HmEmsCeMnSIA==", "023e3f0f-4e73-4346-b5f1-56257ff9b89e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac6a2c5e-92b7-4699-9212-c94266d6e08d", "AQAAAAEAACcQAAAAEPzazPJeHNReBg/Nb9XPdSN6L1EMddxzxhTSYmVcnj4+toiRwm8JSgLtTI2ZlZm5Hg==", "a527484a-cbde-4c34-a691-f924cb7fe746" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 4, 9, 14, 3, 546, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "Id", "Name", "NumberOfSeats" },
                values: new object[,]
                {
                    { 1, "Green Stage", 0 },
                    { 2, "Small Room", 0 },
                    { 3, "Hall", 0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "Id");
        }
    }
}
