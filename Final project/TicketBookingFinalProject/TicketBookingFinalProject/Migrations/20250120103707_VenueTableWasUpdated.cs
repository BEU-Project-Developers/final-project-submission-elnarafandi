using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketBookingFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class VenueTableWasUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalSeats",
                table: "Venues",
                newName: "Capacity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Venues",
                newName: "TotalSeats");
        }
    }
}
