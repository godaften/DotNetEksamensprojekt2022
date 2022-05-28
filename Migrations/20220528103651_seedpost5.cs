using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class seedpost5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "265a4689-9940-4bc2-8932-b757b785400c", "AQAAAAEAACcQAAAAECXEQKvi+rwWPQs19iOcwoFnPUDF5z8fUtL4YoH63H4g7aeLHcRopXk4GsPb5eUEog==", "a6085a8d-a418-4b0c-9e68-e2704381a155" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af93943a-f102-4653-9f6d-0ee96ee9b8e7", "AQAAAAEAACcQAAAAEN7S2Q/WNBtbEBT4+p9rcN+mWsviW2LDlVQ3VRJnsoF2xAKnQLkNgEUkOQxarNNM0g==", "b892d01a-8d27-4c94-b1a8-3b355a7c82f4" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "going on!");

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 2, "going on again!", "PartyUartig" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 36, 51, 398, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 36, 51, 398, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[] { 14, new DateTime(2022, 5, 28, 12, 36, 51, 398, DateTimeKind.Local).AddTicks(1147), 0, "This is post 3", "Post no 3", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad09b935-a128-4d36-b595-a5e5742f059b", "AQAAAAEAACcQAAAAEEweKKsJGm/27aAzKyFanEC+keEEszDdw2UaxAi3JmQh5+m6MqodiHUb2hVN7iZAvw==", "9769ae78-b8d8-4367-8d2b-d9beff64415f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acf51620-bf0f-4759-9de5-0ef10e4e8b2e", "AQAAAAEAACcQAAAAELFWRVbLhAiYwcWpJwfEKgEtmK4tiBDEzqSFPVF6dr1n1UdCmdJEwmwe024xmFHLDQ==", "23b549fe-bd76-4c3b-a9b7-726ce2f8d8e4" });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "going on");

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 34, 9, 769, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                column: "Created",
                value: new DateTime(2022, 5, 28, 12, 34, 9, 769, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "Created", "Status", "Text", "Title", "UserId" },
                values: new object[] { 13, new DateTime(2022, 5, 28, 12, 34, 9, 769, DateTimeKind.Local).AddTicks(5341), 0, "This is post 3", "Post no 3", null });
        }
    }
}
