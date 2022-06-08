using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cbsStudents.Migrations
{
    public partial class dbsetchangedtoplural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_UserId",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venue",
                table: "Venue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Venue",
                newName: "Venues");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Post_UserId",
                table: "Posts",
                newName: "IX_Posts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_VenueId",
                table: "Events",
                newName: "IX_Events_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venues",
                table: "Venues",
                column: "VenueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "CommentId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1fbc1bd-2614-47c0-b37c-0e5e40642202", "AQAAAAEAACcQAAAAEEu2N0x5RMpVpBBfztlh4Fr1H2ccCt6JZK3y+IR62dqQszK3eXwKXJNbuO8e8Rqzow==", "f376fba9-ed10-43a4-8ac8-073f33cef9e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "162ce463-3140-4c31-b755-cc75f02a2502", "AQAAAAEAACcQAAAAEHnBxxIlaEEgAkxr98QS8B5UFOrpvkTmEP7ZQ3HIrvutP251OXUcMcsY2QxKhVgTig==", "ea6b1846-e608-492d-8cc9-5c36b2d94631" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6788), new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6793), new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6797), new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 7, 23, 33, 37, 788, DateTimeKind.Local).AddTicks(6592));

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venues",
                table: "Venues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Venues",
                newName: "Venue");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserId",
                table: "Post",
                newName: "IX_Post_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_VenueId",
                table: "Event",
                newName: "IX_Event_VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comment",
                newName: "IX_Comment_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venue",
                table: "Venue",
                column: "VenueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "CommentId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6eaf38c-a89b-4c74-bb6b-01c48b2118cb", "AQAAAAEAACcQAAAAEPFsj+jQpfDxBfl0mFeoXBf8CaURz1VHUVWu82EMMhS8/hzM+beuH++2EA0xqTK48Q==", "73a8dd61-cc2a-4fff-8177-28a28b358750" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41047201-1949-4f77-a48a-02e335f5de84", "AQAAAAEAACcQAAAAEOW4OyV0/NGtFhKyunZ1BZ4oAMtPCoU+LzvT3BFvqKPjBYo1C5DlvO1FTerkY6tAww==", "330febea-d288-4ecd-9ceb-a933b1fd8251" });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "TimeStamp",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8351), new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8356), new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EventEndDateTime", "EventStartDateTime" },
                values: new object[] { new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8361), new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                column: "Created",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                column: "Created",
                value: new DateTime(2022, 6, 7, 12, 7, 39, 837, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Post_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Venue_VenueId",
                table: "Event",
                column: "VenueId",
                principalTable: "Venue",
                principalColumn: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_UserId",
                table: "Post",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
