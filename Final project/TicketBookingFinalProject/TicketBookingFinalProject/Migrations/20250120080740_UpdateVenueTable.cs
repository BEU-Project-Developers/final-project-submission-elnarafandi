using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBookingFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVenueTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VenueId",
                table: "Venues",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Venues",
                newName: "VenueId");
        }
    }
}
