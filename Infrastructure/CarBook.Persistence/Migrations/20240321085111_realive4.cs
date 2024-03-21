using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class realive4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DropOffLocationId",
                table: "Reservations",
                column: "DropOffLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PickUpLocationId",
                table: "Reservations",
                column: "PickUpLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_DropOffLocationId",
                table: "Reservations",
                column: "DropOffLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Locations_PickUpLocationId",
                table: "Reservations",
                column: "PickUpLocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_DropOffLocationId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Locations_PickUpLocationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DropOffLocationId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_PickUpLocationId",
                table: "Reservations");
        }
    }
}
