using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace_Orders.Migrations
{
    /// <inheritdoc />
    public partial class ProductMarketPlace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MarketPlaceId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Products_MarketPlaceId",
                table: "Products",
                column: "MarketPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MarketPlaces_MarketPlaceId",
                table: "Products",
                column: "MarketPlaceId",
                principalTable: "MarketPlaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_MarketPlaces_MarketPlaceId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MarketPlaceId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MarketPlaceId",
                table: "Products");
        }
    }
}
