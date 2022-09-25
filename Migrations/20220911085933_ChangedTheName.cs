using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketPlace_Orders.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTheName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Outlets");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("013cd00b-8c02-4f14-8222-f30ae0787579"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("063b823b-a98b-4edf-9335-be396ff5dac9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("082ffcfc-a8b1-403f-80a1-55210cf3439e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("163a2e0b-74aa-4d6e-af58-b5736782daa0"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("2281bd58-14ea-4513-a234-291d9268c432"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("260259af-8388-40ae-ba14-e8ffb73d3161"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("26d44697-7fe3-454e-adbf-8b3242627e5d"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("27787c3b-b1c3-440c-93b1-606d7cfe87c4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("324cac62-479d-4dda-b37a-d773eecc2896"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("3f33106f-457f-4fe3-811d-2070792bf055"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("42c7ef65-e6a4-44ab-9614-121987f18da2"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("43c38acb-8807-4e3f-abcb-c9a3a02f8393"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("441f1e58-8f4d-4687-a5ee-1b6107df17c2"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("54acb281-3cf3-4add-a86a-ae33e4787b4c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("5611e3e7-fbf2-4ecc-b204-df2d5bbe6511"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("5681e364-92d6-44cc-a2ae-2ea9a681ac90"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6186a528-8734-4f5c-b214-1876fe278101"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6a8939e7-2a90-4987-878c-87c838ec9241"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("74d5e580-4216-4bcf-babd-b68dbe04ee8e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("7727843f-4b5e-4bbc-b4ec-09ac52a6bab2"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("77c61e09-cbb9-41b3-a2fb-06b9871e43ed"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("7a18521d-ab30-487c-a488-60d1bc95504a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("7bcc009e-0fa0-4fbb-b890-d2e0e1650242"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("7f0c39ae-15a9-47b4-875e-034464ebb119"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("811a2a81-e1d4-4bd8-a32f-166b6b3ce1d5"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8322c278-0525-4f6c-834d-0a33a72bf1ff"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8691b414-6e05-4414-a460-5260ad110c29"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("885918c3-8504-4b7c-9715-96597d32263e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("91887dde-7975-4c0b-8420-cc6987b08529"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("968c49f1-ae38-4ea5-8006-c3fe5f74946e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("98adf68a-e202-40f2-9856-8cbed7f23d42"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a191afc3-fe45-4af8-9d9f-298e016cc197"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a289608d-80e0-4165-a1fd-a36970fadbfb"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b1be0163-d57e-4987-9f6e-54679ec0e19d"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b9273244-ab8f-4df9-acc9-62f3a5754e99"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b95649a5-c5d6-4447-a66c-bbb7aae4e0c2"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("c00dffc1-3361-4607-ba36-8014f73558d9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("c22e8db9-4bd2-418b-9cd4-218531150f3a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("c7723ff6-e3e7-43e5-af49-a15d221cdbae"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("cc58f45b-dc10-4140-a185-485c1eb0a0c9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e25c7c80-736b-4a79-8013-9387759a2aa9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e3fd3b4a-d9c8-40d2-bfc8-0dce622f8321"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e5e61414-857b-451a-8ce7-5db96b3042ad"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e94a00e6-080b-43ff-ae1e-91762f8df0d7"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ed104c5b-201f-4f40-b486-3d679cfe4c9b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ede12711-d7ca-4f1c-a422-b0c916ffd540"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ee563e97-36a7-461c-80cf-d51eea8467bd"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("efd80673-98eb-442a-a690-33e6edf7aaab"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f9f6bc6c-89be-4384-8e86-335edc89c1b9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("fe427791-a705-4c50-89f7-6694d33a517b"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("11ddaa28-d601-46bd-967d-6475aa06c329"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("41a8ed9f-8033-4a8b-b777-70f33a253c5e"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("70c6ccc4-9fb9-4b77-b7cd-0d3b541d1438"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("8f4ed288-7a20-4855-8786-ecef5ca111e4"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("183b49eb-9e49-42fd-8b48-f010d8202c4b"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("255f3953-dd20-484d-a2b4-34fe9635294c"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("b0520728-f5d1-477f-afeb-3dc2de3f3b03"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("b24030f0-7a8e-45fa-8faf-45fdf9265852"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("f87e3ef4-a1bd-413a-8bc7-67b3a207cf37"));

            migrationBuilder.CreateTable(
                name: "Products",
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
                    { new Guid("0242de8d-d336-4ba2-9eba-4acbcd6cca87"), "Delhi", "Vishesh Rathod" },
                    { new Guid("0b6dc3aa-ca7a-4e0c-9d5a-acff08ac42d5"), "Chennai", "Aelish Virani" },
                    { new Guid("0c2c78b8-499a-4e01-88dc-ea46fb210de0"), "Gandhinagar", "Tejas Verma" },
                    { new Guid("19e179df-0ccf-4c41-8d13-30590b3c7e61"), "Delhi", "Kush Kushwah" },
                    { new Guid("201a1e56-142c-4060-b2c7-6df37917c8a4"), "Chennai", "Ramesh Rathod" },
                    { new Guid("22a895cc-0049-4f57-91ea-c35b6a29d94e"), "Ahmedabad", "Vishesh Kanzariya" },
                    { new Guid("360d18ab-a28b-4606-a665-13b9ae1329ba"), "Goa", "Amit Sharma" },
                    { new Guid("3fb56f4b-c575-42f5-ad52-e8f67f684fc0"), "Ahmedabad", "Aelish Parmar" },
                    { new Guid("4502af7b-002e-4fb8-a329-5d9d8804183e"), "Kolkata", "Amit Kanzariya" },
                    { new Guid("49012979-a33c-42d9-8d89-b28104f1a13b"), "Bangalore", "Kush Sharma" },
                    { new Guid("4af980ca-c6d0-4ee1-adc7-5a6323c8a1ec"), "Kolkata", "Harsh Rathod" },
                    { new Guid("50da3f81-2745-4151-a2fe-9f5453e7f1f9"), "Delhi", "Naisarg Kanzariya" },
                    { new Guid("59294ed8-c82b-4cfe-befc-67c189adb739"), "Ahmedabad", "Darshil Agrawal" },
                    { new Guid("59dabe54-cec6-4b06-9c99-4921b6811813"), "Bangalore", "Harsh Sharma" },
                    { new Guid("66393eb8-919b-40b3-a3e1-04641bcb70e9"), "Goa", "Amit Verma" },
                    { new Guid("69442587-fa39-4d60-94ef-65e1fc6db71c"), "Mumbai", "Naisarg Maheriya" },
                    { new Guid("6a77c9e1-80cb-4e18-a999-507d7816fd84"), "Gandhinagar", "Raj Verma" },
                    { new Guid("6bead8b0-6156-4159-b32f-10c39c049531"), "Kolkata", "Amit Vaghasiya" },
                    { new Guid("6cb4015a-811c-46b3-b9b3-0ae37e9295b6"), "Delhi", "Harsh Virani" },
                    { new Guid("73691056-0073-4cef-9721-01676e29444c"), "Gandhinagar", "Raj Verma" },
                    { new Guid("8019de8a-b207-4d92-aec2-b6e90c528e7c"), "Delhi", "Ramesh Parmar" },
                    { new Guid("805f5fa4-608f-4e16-a4b4-d220d04f1d5b"), "Mumbai", "Naisarg Kushwah" },
                    { new Guid("82d86143-23b7-4379-8ff5-aada60a33496"), "Gandhinagar", "Naisarg Sharma" },
                    { new Guid("8380f93d-0411-41a7-88e2-4390bc76f1ab"), "Kerala", "Aelish Parmar" },
                    { new Guid("8898bcf2-f256-4bda-8d87-5cd626e350ef"), "Delhi", "Raj Agrawal" },
                    { new Guid("897eed88-ed4a-4e23-8c38-c22b25dc17db"), "Kerala", "Ramesh Sharma" },
                    { new Guid("8bab272b-f693-437c-91e0-1dfd1ab7b2fb"), "Chennai", "Aelish Agrawal" },
                    { new Guid("8fdac3e8-7023-4cad-951f-046a0ac864e9"), "Kolkata", "Naisarg Kanzariya" },
                    { new Guid("91ed6d06-d2b5-4d30-84c6-1620989e6783"), "Delhi", "Harsh Rathod" },
                    { new Guid("95f6c96b-2202-453f-ae48-aea42fd28774"), "Ahmedabad", "Aelish Parmar" },
                    { new Guid("a56fc0c4-c7fc-428c-b36b-fd68e793cf6b"), "Kolkata", "Kush Kanzariya" },
                    { new Guid("b26d46a4-0320-4fef-bc23-df19258953a6"), "Pune", "Aelish Verma" },
                    { new Guid("b2d3caea-829a-465a-823d-141fbeccb042"), "Chennai", "Darshil Sharma" },
                    { new Guid("b4d5a717-7a8e-48bf-a8e6-7ddf193ec427"), "Bangalore", "Kush Rathod" },
                    { new Guid("c59d07f8-f2d9-4567-af0c-74ae2169b40a"), "Ahmedabad", "Amit Virani" },
                    { new Guid("cb1fa749-5054-4769-84ef-dd6354c3012d"), "Bangalore", "Harsh Vaghasiya" },
                    { new Guid("cb507826-46b1-4940-a057-8bd296f478c9"), "Chennai", "Vishesh Kushwah" },
                    { new Guid("cdd56eff-3020-40ac-8fd7-f9d2044ea39e"), "Mumbai", "Tejas Virani" },
                    { new Guid("cfbea068-d077-422a-b49a-69679f11edfa"), "Mumbai", "Tejas Sharma" },
                    { new Guid("d2240e73-42b0-412c-89f2-1b5d55781431"), "Gandhinagar", "Amit Agrawal" },
                    { new Guid("d6672141-ec28-4aa2-ab32-48db271e88ad"), "Kerala", "Ramesh Maheriya" },
                    { new Guid("dae3a92f-9736-4b92-bd7d-fa92c053f04e"), "Kerala", "Darshil Rathod" },
                    { new Guid("dc2004cb-3531-4eff-9ac0-4ee3dc03726a"), "Kerala", "Naisarg Virani" },
                    { new Guid("e66f05b3-a711-4851-b161-dffa928fa5ed"), "Kerala", "Kush Kushwah" },
                    { new Guid("f288c7fd-ac77-46ad-9b4a-86c946f3b613"), "Chennai", "Kush Agrawal" },
                    { new Guid("f37bcb4e-de67-464b-82b1-912056daa32a"), "Pune", "Raj Kushwah" },
                    { new Guid("f71e3b2f-f072-435d-b90e-2b7f370db5cf"), "Ahmedabad", "Darshil Parmar" },
                    { new Guid("f914c7ee-61ec-4342-9b7b-fb5e1b6f4069"), "Gandhinagar", "Ramesh Sharma" },
                    { new Guid("f9cddba0-e60c-4c34-b9cc-bbb24ee2ef74"), "Chennai", "Darshil Maheriya" },
                    { new Guid("ff342ec2-6acb-4768-a5db-802225748d26"), "Kerala", "Harsh Vaghasiya" }
                });

            migrationBuilder.InsertData(
                table: "MarketPlaces",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2966b22d-a425-4dbe-a6e6-06e3e4d1f28b"), "Swiggy" },
                    { new Guid("32c9b55a-8c48-42ec-bf76-0eba6f44cfc4"), "Food Panda" },
                    { new Guid("6a3f246d-bb61-4b92-9171-8f3610fd5081"), "Zomato" },
                    { new Guid("6c2048f8-d34c-42ef-9721-48dbe55f4db3"), "Uber Eats" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0092455a-6112-4ba5-9b45-e523653195b3"), "KFC" },
                    { new Guid("53a9e872-de54-42b8-81ae-2f4a6ecde0a8"), "City Point" },
                    { new Guid("61382ee7-21ad-44bd-9de6-5321affcc367"), "Farki " },
                    { new Guid("6d4f7560-985e-4f6b-91fd-bb9a25554c45"), "Pizza Hut" },
                    { new Guid("99dba099-88a5-4ca5-8efd-c70f62dd937b"), "Dominos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_RestaurantId1",
                table: "Products",
                column: "RestaurantId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0242de8d-d336-4ba2-9eba-4acbcd6cca87"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0b6dc3aa-ca7a-4e0c-9d5a-acff08ac42d5"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0c2c78b8-499a-4e01-88dc-ea46fb210de0"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("19e179df-0ccf-4c41-8d13-30590b3c7e61"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("201a1e56-142c-4060-b2c7-6df37917c8a4"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("22a895cc-0049-4f57-91ea-c35b6a29d94e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("360d18ab-a28b-4606-a665-13b9ae1329ba"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("3fb56f4b-c575-42f5-ad52-e8f67f684fc0"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("4502af7b-002e-4fb8-a329-5d9d8804183e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("49012979-a33c-42d9-8d89-b28104f1a13b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("4af980ca-c6d0-4ee1-adc7-5a6323c8a1ec"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("50da3f81-2745-4151-a2fe-9f5453e7f1f9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("59294ed8-c82b-4cfe-befc-67c189adb739"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("59dabe54-cec6-4b06-9c99-4921b6811813"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("66393eb8-919b-40b3-a3e1-04641bcb70e9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("69442587-fa39-4d60-94ef-65e1fc6db71c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6a77c9e1-80cb-4e18-a999-507d7816fd84"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6bead8b0-6156-4159-b32f-10c39c049531"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("6cb4015a-811c-46b3-b9b3-0ae37e9295b6"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("73691056-0073-4cef-9721-01676e29444c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8019de8a-b207-4d92-aec2-b6e90c528e7c"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("805f5fa4-608f-4e16-a4b4-d220d04f1d5b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("82d86143-23b7-4379-8ff5-aada60a33496"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8380f93d-0411-41a7-88e2-4390bc76f1ab"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8898bcf2-f256-4bda-8d87-5cd626e350ef"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("897eed88-ed4a-4e23-8c38-c22b25dc17db"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8bab272b-f693-437c-91e0-1dfd1ab7b2fb"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("8fdac3e8-7023-4cad-951f-046a0ac864e9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("91ed6d06-d2b5-4d30-84c6-1620989e6783"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("95f6c96b-2202-453f-ae48-aea42fd28774"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("a56fc0c4-c7fc-428c-b36b-fd68e793cf6b"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b26d46a4-0320-4fef-bc23-df19258953a6"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b2d3caea-829a-465a-823d-141fbeccb042"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b4d5a717-7a8e-48bf-a8e6-7ddf193ec427"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("c59d07f8-f2d9-4567-af0c-74ae2169b40a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("cb1fa749-5054-4769-84ef-dd6354c3012d"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("cb507826-46b1-4940-a057-8bd296f478c9"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("cdd56eff-3020-40ac-8fd7-f9d2044ea39e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("cfbea068-d077-422a-b49a-69679f11edfa"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("d2240e73-42b0-412c-89f2-1b5d55781431"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("d6672141-ec28-4aa2-ab32-48db271e88ad"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("dae3a92f-9736-4b92-bd7d-fa92c053f04e"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("dc2004cb-3531-4eff-9ac0-4ee3dc03726a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("e66f05b3-a711-4851-b161-dffa928fa5ed"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f288c7fd-ac77-46ad-9b4a-86c946f3b613"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f37bcb4e-de67-464b-82b1-912056daa32a"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f71e3b2f-f072-435d-b90e-2b7f370db5cf"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f914c7ee-61ec-4342-9b7b-fb5e1b6f4069"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f9cddba0-e60c-4c34-b9cc-bbb24ee2ef74"));

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ff342ec2-6acb-4768-a5db-802225748d26"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("2966b22d-a425-4dbe-a6e6-06e3e4d1f28b"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("32c9b55a-8c48-42ec-bf76-0eba6f44cfc4"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("6a3f246d-bb61-4b92-9171-8f3610fd5081"));

            migrationBuilder.DeleteData(
                table: "MarketPlaces",
                keyColumn: "Id",
                keyValue: new Guid("6c2048f8-d34c-42ef-9721-48dbe55f4db3"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("0092455a-6112-4ba5-9b45-e523653195b3"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("53a9e872-de54-42b8-81ae-2f4a6ecde0a8"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("61382ee7-21ad-44bd-9de6-5321affcc367"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("6d4f7560-985e-4f6b-91fd-bb9a25554c45"));

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: new Guid("99dba099-88a5-4ca5-8efd-c70f62dd937b"));

            migrationBuilder.CreateTable(
                name: "Outlets",
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
    }
}
