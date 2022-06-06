using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class db14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: "2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb99d4ab-78dc-4a24-8c2c-adeb928afe77", "AQAAAAEAACcQAAAAECvlMGpE7fzkjPQ2dZTrofbdQcnbIQdAMscgD94WeSm6E8oTT+pLl6zuh/BThYB/6g==", "7341e852-a98d-4a30-af5c-d6bdfb4cf3eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d31816d0-123c-4e82-adaf-2e4d37b8b3b6", "AQAAAAEAACcQAAAAEJKm+wpzU6wn2e4R8r8UGoGo7+Y91kE9cz8I8i6tuvlX+E3L2eO79mVOTUvoPPJ1zQ==", "84650574-9718-42d7-921d-3dfb128d530d" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "EventEndDateTime", "EventGenre", "EventStartDateTime", "ImageName", "Title" },
                values: new object[] { "Come join everybody having fun!", new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8736), "Comedy", new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8733), "77a05c90-f3e1-46df-8bae-9e2098da08b6_AA9EA89A-CDF9-4DE0-8FC6-0D17D573BADF.jpeg", "All night Fun with Jokes" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Adress", "City", "Country", "Description", "EventEndDateTime", "EventGenre", "EventStartDateTime", "ImageName", "Online", "Title", "VenueId" },
                values: new object[,]
                {
                    { 101, "Funnystreet 10", "Copenhagen", "Denmark", "Greatest voice alive!", new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8741), "Concert", new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8739), "", false, "John live at the stage", null },
                    { 102, "", "", "", "Laugh out loud alone!", new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8746), "Comedy", new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8745), "", true, "Fun at home?", null }
                });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 6, 13, 45, 49, 248, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Name", "NumberOfSeats" },
                values: new object[,]
                {
                    { "Green", "Green Stage", 100 },
                    { "Hall", "Hall", 250 },
                    { "Small", "Small Room", 200 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: "Green");

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: "Hall");

            migrationBuilder.DeleteData(
                table: "Venue",
                keyColumn: "VenueId",
                keyValue: "Small");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e0d311e-da7e-4d1f-bda1-e4b5bf785c5e", "AQAAAAEAACcQAAAAENOkz1vSaUNMaQ3HgOdCYf8pYQuMz06sdrca2+PdEIYU36Lwpt1AXx99M7ov/Vbuig==", "fefd3f0a-5c90-4ac3-8c29-9b6b6725574f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0ffb00e-a1f0-43c0-a676-1d1692c43fff", "AQAAAAEAACcQAAAAEKUFDvZCmKEaRLQP2pNkD4mSOm6x4LPYhshFbSuokREieXiVVawYzvyzskGt2ejjfA==", "51d1a3ab-644c-45bb-8623-111eb54f89c9" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 6, 11, 58, 58, 442, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "EventEndDateTime", "EventGenre", "EventStartDateTime", "ImageName", "Title" },
                values: new object[] { "going on!", new DateTime(2022, 6, 6, 11, 58, 58, 442, DateTimeKind.Local).AddTicks(5762), null, new DateTime(2022, 6, 6, 11, 58, 58, 442, DateTimeKind.Local).AddTicks(5759), null, "Party" });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 6, 11, 58, 58, 442, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 6, 11, 58, 58, 442, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 6, 11, 58, 58, 442, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueId", "Name", "NumberOfSeats" },
                values: new object[,]
                {
                    { "1", "Green Stage", 100 },
                    { "2", "Small Room", 200 }
                });
        }
    }
}
