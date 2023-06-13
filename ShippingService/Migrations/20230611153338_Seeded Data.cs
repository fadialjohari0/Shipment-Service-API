using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShippingService.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shipments",
                columns: new[] { "Id", "CarrierServiceId", "ShipmentId" },
                values: new object[,]
                {
                    { 1, "fedexAIR", "FedEX" },
                    { 2, "fedexGROUND", "FedEX" }
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Height", "Length", "ShipmentId", "Weight", "Width" },
                values: new object[,]
                {
                    { 1, 10.0, 10.0, 1, 10.0, 10.0 },
                    { 2, 20.0, 20.0, 2, 20.0, 20.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shipments",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
