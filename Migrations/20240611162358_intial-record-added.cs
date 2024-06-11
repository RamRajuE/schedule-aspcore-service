using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schedule_aspcore_service.Migrations
{
    /// <inheritdoc />
    public partial class intialrecordadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ScheduleTableAspCore",
                columns: new[] { "Id", "Description", "EndTime", "EndTimezone", "FollowingID", "Guid", "IsAllDay", "IsBlock", "IsReadOnly", "Location", "OwnerId", "RecurrenceException", "RecurrenceID", "RecurrenceRule", "StartTime", "StartTimezone", "Subject" },
                values: new object[] { 1, null, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, null, null, null, null, null, null, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Intial item" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScheduleTableAspCore",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
