using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class eventadresscitycountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e31e7641-f1af-4ea9-bb6e-e423b9cd11a0", "AQAAAAEAACcQAAAAEHGzCnW+0FtQH2bq4YTPSF/xXr9vX6Z1fCbgx0J/kqQnHpCFRpV0ePBl/rfd92qs8g==", "8e8f2933-4236-4bb7-a55f-68db76642f78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fa9a09f-d8f1-424c-8910-b961884eb2e2", "AQAAAAEAACcQAAAAENqUOwBemqqv+khOPK15+hFaNQw0+RuNRVuO6n3jl6lDDHAcg1e508rLnK7/jUpCsw==", "8e393503-20e0-43fe-ad5e-02de4e404926" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Adress", "City", "Country", "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { "Funnystreet 10", "Copenhagen", "Denmark", new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3659), new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 58, 15, 524, DateTimeKind.Local).AddTicks(3586));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Event");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "376e63b1-2e02-4a66-94da-b50601061364", "AQAAAAEAACcQAAAAEMSFMjy02/bkFFqdVxAaq8X18LXxNzNXgvA4G40kfsN0v8EfKtqkFIAuz6K5Q5t9+A==", "aff75d40-80d4-4125-a07a-0b67fc614fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4edcdcb-e981-42ed-b861-8b4cef89750e", "AQAAAAEAACcQAAAAEK2JB17WPKgnPCwccqhWlEfWgEJU5feBGO8WPTr/yhEysRKq3CHPHa6kxGv6dUjYMA==", "39a9c126-17b7-4e79-a8b7-dc05a0fafc91" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5533), new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 5, 29, 12, 43, 4, 977, DateTimeKind.Local).AddTicks(5477));
        }
    }
}
