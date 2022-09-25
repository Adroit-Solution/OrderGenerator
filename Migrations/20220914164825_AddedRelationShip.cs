using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace_Orders.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationShip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MarketPlaceName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RestMarketRelate",
                columns: table => new
                {
                    Restaurant = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MarketPlace = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestMarketRelate", x => new { x.MarketPlace, x.Restaurant });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestMarketRelate");

            migrationBuilder.DropColumn(
                name: "MarketPlaceName",
                table: "Orders");
        }
    }
}
