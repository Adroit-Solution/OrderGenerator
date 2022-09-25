using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace_Orders.Migrations
{
    /// <inheritdoc />
    public partial class DeleteProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("02d10ff5-802e-4595-b9de-d9f597b3f8be"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("033279f0-009f-4bb5-ab11-458a196eef05"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0d75100f-9d2a-47d9-bb7d-0139a6ede622"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("10d48611-681f-4d26-9baf-c985c775bab8"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("127c77f9-8836-4ef9-adf0-4761b4e03acb"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("13597617-f48d-45d6-bfd9-88819ad06b53"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("15bb5efc-f36a-4e34-b132-5f0aa8be9c95"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("16f97040-30b5-4e53-85d0-2d24fd1eae8b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("21255588-9d9e-4529-99f6-604908b40ae7"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("2491968a-c0d5-4fa7-b8f2-7a30b3c6fe58"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("28bbe30e-0e49-45b3-966e-f6f20790a167"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("3736aeef-6350-4f1f-a947-e640f4baa2b4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("3e448bcb-8f4c-430f-8d4c-65c937af51c4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("4aa3f273-128f-4e93-a24a-60e9ab4c568a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("4ebc1241-84f7-4335-b779-b6887bd5d44d"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("524ffef3-e0d0-4291-ac76-729874d19a27"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("542873a2-29c5-47e3-8793-7929c7605b78"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("592d98ce-942e-45f8-bb3e-733312d2de5c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("5c8c529c-4896-4132-9a13-48dbbee650a6"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6781b274-1e2c-481e-8529-e192fb2b799f"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("69de1030-d3bd-4630-adfa-4ad52395f538"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6f73de6c-ae34-4f2e-bfc2-70ede09c1a75"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("779538e2-221b-459e-9362-c773d154bf4e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("83bbe6bd-da6e-4246-99a0-0d92ad31127b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8875f86a-d830-4934-a7d7-8fc2dff8b318"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("941ce9ee-ff67-4339-8231-101c61c0c2e8"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("9e1f9ae8-7af5-4a6c-8f13-d294f314546c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a220605a-2505-4876-aa0e-b03b01b3bfe0"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a3fee42d-89ea-4e71-aae1-81e52e70903c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a42918de-ac15-4096-bc05-8d5a9a12feeb"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a57a9bb5-ad3d-406c-a1fb-9f4614619d6e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a6227165-ef8c-4c49-87a9-367a4e0ba4e7"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a777afdb-6aff-4b41-9177-8ce9acf2ae54"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b0d54b53-968b-49e2-ada2-52aab6dee7f4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b4267c6c-8e89-454a-9402-4cb0d46372b2"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b96748f4-30ce-491d-9c1e-34f7416ec983"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("c68eac15-b2fb-42a0-ab20-f31195f44bd2"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("c6cefcb6-c330-4944-a8e6-5eb8bf92fc53"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("c9e4cf71-1c5c-429d-9c37-8510b75beb3c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("cd871242-5e86-4470-888f-43a321271fc9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("d195af26-763d-413c-a12b-4f25f80b118f"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("d2fa988a-d82b-4bfe-b047-8c33e7a2d34a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("dbabbf67-4111-4d20-b494-6e62a8b8d26a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("df1e9f15-c888-4ec7-acec-a6ed10fc16b4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e2bf4ef0-e43f-4f8f-ae0a-17e3c54e9264"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e6937e55-471a-4af0-a950-6b6f85301ad8"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e80e9713-7483-416a-960e-d9470542126a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ea6e3c47-ceb3-49f7-abce-510185d00420"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f1c591e3-5b65-456c-8a68-49655a583e0e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("fdeacda7-0ac9-40d0-9bae-707123dfdf6e"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("0b271f6b-575d-4e9c-8e18-75364dda57f7"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("41424202-6d92-4ea3-8205-bebeb873f1fd"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("674e04bf-8533-4b5f-b9f8-12bb45db4589"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("6d9c4ef6-0217-4445-9567-346f480828d1"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("02fd65a1-6d1a-4c66-a589-7eb0cc357080"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("53903fd0-850f-41e4-a8dd-64a48671c208"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("7625e355-e88a-435a-bbaa-63de273a0c3a"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("828d3869-45eb-4124-9bbe-a5b4d62dd29d"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("cf58c79a-ab87-4e89-9560-2165610f46cc"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Restaurants_RestaurantId1",
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
                    { new Guid("02d10ff5-802e-4595-b9de-d9f597b3f8be"), "Gandhinagar", "Darshil Maheriya" },
                    { new Guid("033279f0-009f-4bb5-ab11-458a196eef05"), "Mumbai", "Kush Kanzariya" },
                    { new Guid("0d75100f-9d2a-47d9-bb7d-0139a6ede622"), "Chennai", "Vishesh Virani" },
                    { new Guid("10d48611-681f-4d26-9baf-c985c775bab8"), "Delhi", "Tejas Virani" },
                    { new Guid("127c77f9-8836-4ef9-adf0-4761b4e03acb"), "Pune", "Vishesh Agrawal" },
                    { new Guid("13597617-f48d-45d6-bfd9-88819ad06b53"), "Kolkata", "Kush Virani" },
                    { new Guid("15bb5efc-f36a-4e34-b132-5f0aa8be9c95"), "Gandhinagar", "Tejas Kanzariya" },
                    { new Guid("16f97040-30b5-4e53-85d0-2d24fd1eae8b"), "Pune", "Aelish Agrawal" },
                    { new Guid("21255588-9d9e-4529-99f6-604908b40ae7"), "Gandhinagar", "Harsh Virani" },
                    { new Guid("2491968a-c0d5-4fa7-b8f2-7a30b3c6fe58"), "Pune", "Harsh Agrawal" },
                    { new Guid("28bbe30e-0e49-45b3-966e-f6f20790a167"), "Pune", "Kush Maheriya" },
                    { new Guid("3736aeef-6350-4f1f-a947-e640f4baa2b4"), "Kerala", "Darshil Virani" },
                    { new Guid("3e448bcb-8f4c-430f-8d4c-65c937af51c4"), "Kerala", "Vishesh Agrawal" },
                    { new Guid("4aa3f273-128f-4e93-a24a-60e9ab4c568a"), "Delhi", "Tejas Agrawal" },
                    { new Guid("4ebc1241-84f7-4335-b779-b6887bd5d44d"), "Kolkata", "Kush Vaghasiya" },
                    { new Guid("524ffef3-e0d0-4291-ac76-729874d19a27"), "Mumbai", "Darshil Agrawal" },
                    { new Guid("542873a2-29c5-47e3-8793-7929c7605b78"), "Chennai", "Harsh Parmar" },
                    { new Guid("592d98ce-942e-45f8-bb3e-733312d2de5c"), "Delhi", "Aelish Kanzariya" },
                    { new Guid("5c8c529c-4896-4132-9a13-48dbbee650a6"), "Ahmedabad", "Kush Vaghasiya" },
                    { new Guid("6781b274-1e2c-481e-8529-e192fb2b799f"), "Ahmedabad", "Kush Agrawal" },
                    { new Guid("69de1030-d3bd-4630-adfa-4ad52395f538"), "Kerala", "Vishesh Virani" },
                    { new Guid("6f73de6c-ae34-4f2e-bfc2-70ede09c1a75"), "Kerala", "Harsh Parmar" },
                    { new Guid("779538e2-221b-459e-9362-c773d154bf4e"), "Pune", "Darshil Parmar" },
                    { new Guid("83bbe6bd-da6e-4246-99a0-0d92ad31127b"), "Ahmedabad", "Vishesh Parmar" },
                    { new Guid("8875f86a-d830-4934-a7d7-8fc2dff8b318"), "Goa", "Darshil Virani" },
                    { new Guid("941ce9ee-ff67-4339-8231-101c61c0c2e8"), "Bangalore", "Kush Vaghasiya" },
                    { new Guid("9e1f9ae8-7af5-4a6c-8f13-d294f314546c"), "Ahmedabad", "Tejas Vaghasiya" },
                    { new Guid("a220605a-2505-4876-aa0e-b03b01b3bfe0"), "Ahmedabad", "Tejas Vaghasiya" },
                    { new Guid("a3fee42d-89ea-4e71-aae1-81e52e70903c"), "Delhi", "Harsh Maheriya" },
                    { new Guid("a42918de-ac15-4096-bc05-8d5a9a12feeb"), "Kerala", "Darshil Maheriya" },
                    { new Guid("a57a9bb5-ad3d-406c-a1fb-9f4614619d6e"), "Mumbai", "Tejas Virani" },
                    { new Guid("a6227165-ef8c-4c49-87a9-367a4e0ba4e7"), "Bangalore", "Darshil Maheriya" },
                    { new Guid("a777afdb-6aff-4b41-9177-8ce9acf2ae54"), "Goa", "Vishesh Kanzariya" },
                    { new Guid("b0d54b53-968b-49e2-ada2-52aab6dee7f4"), "Mumbai", "Darshil Vaghasiya" },
                    { new Guid("b4267c6c-8e89-454a-9402-4cb0d46372b2"), "Mumbai", "Aelish Virani" },
                    { new Guid("b96748f4-30ce-491d-9c1e-34f7416ec983"), "Kerala", "Vishesh Virani" },
                    { new Guid("c68eac15-b2fb-42a0-ab20-f31195f44bd2"), "Ahmedabad", "Aelish Parmar" },
                    { new Guid("c6cefcb6-c330-4944-a8e6-5eb8bf92fc53"), "Kolkata", "Darshil Maheriya" },
                    { new Guid("c9e4cf71-1c5c-429d-9c37-8510b75beb3c"), "Gandhinagar", "Harsh Agrawal" },
                    { new Guid("cd871242-5e86-4470-888f-43a321271fc9"), "Bangalore", "Harsh Maheriya" },
                    { new Guid("d195af26-763d-413c-a12b-4f25f80b118f"), "Kolkata", "Tejas Kanzariya" },
                    { new Guid("d2fa988a-d82b-4bfe-b047-8c33e7a2d34a"), "Delhi", "Harsh Kanzariya" },
                    { new Guid("dbabbf67-4111-4d20-b494-6e62a8b8d26a"), "Mumbai", "Harsh Vaghasiya" },
                    { new Guid("df1e9f15-c888-4ec7-acec-a6ed10fc16b4"), "Gandhinagar", "Harsh Virani" },
                    { new Guid("e2bf4ef0-e43f-4f8f-ae0a-17e3c54e9264"), "Kerala", "Tejas Agrawal" },
                    { new Guid("e6937e55-471a-4af0-a950-6b6f85301ad8"), "Kerala", "Tejas Vaghasiya" },
                    { new Guid("e80e9713-7483-416a-960e-d9470542126a"), "Kerala", "Harsh Virani" },
                    { new Guid("ea6e3c47-ceb3-49f7-abce-510185d00420"), "Mumbai", "Aelish Vaghasiya" },
                    { new Guid("f1c591e3-5b65-456c-8a68-49655a583e0e"), "Kerala", "Vishesh Maheriya" },
                    { new Guid("fdeacda7-0ac9-40d0-9bae-707123dfdf6e"), "Ahmedabad", "Darshil Virani" }
                });

            migrationBuilder.InsertData(
                table: "MarketPlaces",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b271f6b-575d-4e9c-8e18-75364dda57f7"), "Food Panda" },
                    { new Guid("41424202-6d92-4ea3-8205-bebeb873f1fd"), "Zomato" },
                    { new Guid("674e04bf-8533-4b5f-b9f8-12bb45db4589"), "Uber Eats" },
                    { new Guid("6d9c4ef6-0217-4445-9567-346f480828d1"), "Swiggy" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02fd65a1-6d1a-4c66-a589-7eb0cc357080"), "City Point" },
                    { new Guid("53903fd0-850f-41e4-a8dd-64a48671c208"), "Farki " },
                    { new Guid("7625e355-e88a-435a-bbaa-63de273a0c3a"), "Dominos" },
                    { new Guid("828d3869-45eb-4124-9bbe-a5b4d62dd29d"), "KFC" },
                    { new Guid("cf58c79a-ab87-4e89-9560-2165610f46cc"), "Pizza Hut" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_RestaurantId1",
                table: "Products",
                column: "RestaurantId1");
        }
    }
}
