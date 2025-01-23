using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBookingFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class CreatedEventTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Venues_VenueId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EventDate",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EventName",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "VenueId",
                table: "Tickets",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_VenueId",
                table: "Tickets",
                newName: "IX_Tickets_EventId");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VenueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_VenueId",
                table: "Events",
                column: "VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Events_EventId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Tickets",
                newName: "VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_EventId",
                table: "Tickets",
                newName: "IX_Tickets_VenueId");

            migrationBuilder.AddColumn<DateTime>(
                name: "EventDate",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EventName",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Venues_VenueId",
                table: "Tickets",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
