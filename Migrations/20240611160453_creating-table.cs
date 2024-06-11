using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace schedule_aspcore_service.Migrations
{
    /// <inheritdoc />
    public partial class creatingtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleTableAspCore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndTimezone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsAllDay = table.Column<bool>(type: "bit", nullable: true),
                    IsBlock = table.Column<bool>(type: "bit", nullable: true),
                    IsReadOnly = table.Column<bool>(type: "bit", nullable: true),
                    FollowingID = table.Column<int>(type: "int", nullable: true),
                    RecurrenceID = table.Column<int>(type: "int", nullable: true),
                    RecurrenceRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecurrenceException = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTableAspCore", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleTableAspCore");
        }
    }
}
