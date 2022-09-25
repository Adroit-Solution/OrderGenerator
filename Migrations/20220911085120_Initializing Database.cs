using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace_Orders.Migrations
{
    /// <inheritdoc />
    public partial class InitializingDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryBoys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryBoys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketPlaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketPlaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutletName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalBill = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Outlets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    RestaurantId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outlets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Outlets_Restaurants_RestaurantId1",
                        column: x => x.RestaurantId1,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { new Guid("013cd00b-8c02-4f14-8222-f30ae0787579"), "Ahmedabad", "Raj Verma" },
                    { new Guid("063b823b-a98b-4edf-9335-be396ff5dac9"), "Delhi", "Aelish Vaghasiya" },
                    { new Guid("082ffcfc-a8b1-403f-80a1-55210cf3439e"), "Kerala", "Aelish Vaghasiya" },
                    { new Guid("163a2e0b-74aa-4d6e-af58-b5736782daa0"), "Kolkata", "Ramesh Maheriya" },
                    { new Guid("2281bd58-14ea-4513-a234-291d9268c432"), "Delhi", "Amit Agrawal" },
                    { new Guid("260259af-8388-40ae-ba14-e8ffb73d3161"), "Bangalore", "Harsh Agrawal" },
                    { new Guid("26d44697-7fe3-454e-adbf-8b3242627e5d"), "Pune", "Amit Sharma" },
                    { new Guid("27787c3b-b1c3-440c-93b1-606d7cfe87c4"), "Chennai", "Tejas Maheriya" },
                    { new Guid("324cac62-479d-4dda-b37a-d773eecc2896"), "Kolkata", "Harsh Vaghasiya" },
                    { new Guid("3f33106f-457f-4fe3-811d-2070792bf055"), "Pune", "Ramesh Maheriya" },
                    { new Guid("42c7ef65-e6a4-44ab-9614-121987f18da2"), "Kerala", "Harsh Virani" },
                    { new Guid("43c38acb-8807-4e3f-abcb-c9a3a02f8393"), "Ahmedabad", "Amit Rathod" },
                    { new Guid("441f1e58-8f4d-4687-a5ee-1b6107df17c2"), "Gandhinagar", "Kush Agrawal" },
                    { new Guid("54acb281-3cf3-4add-a86a-ae33e4787b4c"), "Bangalore", "Ramesh Sharma" },
                    { new Guid("5611e3e7-fbf2-4ecc-b204-df2d5bbe6511"), "Kerala", "Darshil Kanzariya" },
                    { new Guid("5681e364-92d6-44cc-a2ae-2ea9a681ac90"), "Kerala", "Tejas Virani" },
                    { new Guid("6186a528-8734-4f5c-b214-1876fe278101"), "Delhi", "Raj Rathod" },
                    { new Guid("6a8939e7-2a90-4987-878c-87c838ec9241"), "Mumbai", "Harsh Kanzariya" },
                    { new Guid("74d5e580-4216-4bcf-babd-b68dbe04ee8e"), "Bangalore", "Amit Parmar" },
                    { new Guid("7727843f-4b5e-4bbc-b4ec-09ac52a6bab2"), "Kerala", "Amit Sharma" },
                    { new Guid("77c61e09-cbb9-41b3-a2fb-06b9871e43ed"), "Bangalore", "Raj Parmar" },
                    { new Guid("7a18521d-ab30-487c-a488-60d1bc95504a"), "Kolkata", "Amit Vaghasiya" },
                    { new Guid("7bcc009e-0fa0-4fbb-b890-d2e0e1650242"), "Bangalore", "Amit Virani" },
                    { new Guid("7f0c39ae-15a9-47b4-875e-034464ebb119"), "Goa", "Darshil Kushwah" },
                    { new Guid("811a2a81-e1d4-4bd8-a32f-166b6b3ce1d5"), "Pune", "Ramesh Agrawal" },
                    { new Guid("8322c278-0525-4f6c-834d-0a33a72bf1ff"), "Chennai", "Kush Parmar" },
                    { new Guid("8691b414-6e05-4414-a460-5260ad110c29"), "Bangalore", "Amit Kanzariya" },
                    { new Guid("885918c3-8504-4b7c-9715-96597d32263e"), "Pune", "Naisarg Sharma" },
                    { new Guid("91887dde-7975-4c0b-8420-cc6987b08529"), "Chennai", "Harsh Sharma" },
                    { new Guid("968c49f1-ae38-4ea5-8006-c3fe5f74946e"), "Delhi", "Vishesh Vaghasiya" },
                    { new Guid("98adf68a-e202-40f2-9856-8cbed7f23d42"), "Goa", "Raj Sharma" },
                    { new Guid("a191afc3-fe45-4af8-9d9f-298e016cc197"), "Ahmedabad", "Darshil Rathod" },
                    { new Guid("a289608d-80e0-4165-a1fd-a36970fadbfb"), "Mumbai", "Vishesh Verma" },
                    { new Guid("b1be0163-d57e-4987-9f6e-54679ec0e19d"), "Bangalore", "Harsh Virani" },
                    { new Guid("b9273244-ab8f-4df9-acc9-62f3a5754e99"), "Pune", "Ramesh Maheriya" },
                    { new Guid("b95649a5-c5d6-4447-a66c-bbb7aae4e0c2"), "Goa", "Aelish Virani" },
                    { new Guid("c00dffc1-3361-4607-ba36-8014f73558d9"), "Mumbai", "Kush Sharma" },
                    { new Guid("c22e8db9-4bd2-418b-9cd4-218531150f3a"), "Mumbai", "Naisarg Rathod" },
                    { new Guid("c7723ff6-e3e7-43e5-af49-a15d221cdbae"), "Delhi", "Amit Maheriya" },
                    { new Guid("cc58f45b-dc10-4140-a185-485c1eb0a0c9"), "Pune", "Darshil Virani" },
                    { new Guid("e25c7c80-736b-4a79-8013-9387759a2aa9"), "Kerala", "Naisarg Parmar" },
                    { new Guid("e3fd3b4a-d9c8-40d2-bfc8-0dce622f8321"), "Gandhinagar", "Amit Kanzariya" },
                    { new Guid("e5e61414-857b-451a-8ce7-5db96b3042ad"), "Gandhinagar", "Raj Verma" },
                    { new Guid("e94a00e6-080b-43ff-ae1e-91762f8df0d7"), "Pune", "Raj Agrawal" },
                    { new Guid("ed104c5b-201f-4f40-b486-3d679cfe4c9b"), "Pune", "Harsh Vaghasiya" },
                    { new Guid("ede12711-d7ca-4f1c-a422-b0c916ffd540"), "Kolkata", "Kush Parmar" },
                    { new Guid("ee563e97-36a7-461c-80cf-d51eea8467bd"), "Kerala", "Naisarg Rathod" },
                    { new Guid("efd80673-98eb-442a-a690-33e6edf7aaab"), "Bangalore", "Kush Sharma" },
                    { new Guid("f9f6bc6c-89be-4384-8e86-335edc89c1b9"), "Gandhinagar", "Vishesh Virani" },
                    { new Guid("fe427791-a705-4c50-89f7-6694d33a517b"), "Kolkata", "Aelish Parmar" }
                });

            migrationBuilder.InsertData(
                table: "MarketPlaces",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11ddaa28-d601-46bd-967d-6475aa06c329"), "Food Panda" },
                    { new Guid("41a8ed9f-8033-4a8b-b777-70f33a253c5e"), "Zomato" },
                    { new Guid("70c6ccc4-9fb9-4b77-b7cd-0d3b541d1438"), "Swiggy" },
                    { new Guid("8f4ed288-7a20-4855-8786-ecef5ca111e4"), "Uber Eats" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("183b49eb-9e49-42fd-8b48-f010d8202c4b"), "City Point" },
                    { new Guid("255f3953-dd20-484d-a2b4-34fe9635294c"), "Pizza Hut" },
                    { new Guid("b0520728-f5d1-477f-afeb-3dc2de3f3b03"), "KFC" },
                    { new Guid("b24030f0-7a8e-45fa-8faf-45fdf9265852"), "Farki " },
                    { new Guid("f87e3ef4-a1bd-413a-8bc7-67b3a207cf37"), "Dominos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Outlets_RestaurantId1",
                table: "Outlets",
                column: "RestaurantId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "DeliveryBoys");

            migrationBuilder.DropTable(
                name: "MarketPlaces");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Outlets");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
