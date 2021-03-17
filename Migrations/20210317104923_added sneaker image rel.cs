using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_herhaling_sneakers.Migrations
{
    public partial class addedsneakerimagerel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("8a0ec09e-c95a-4742-a110-1479f4fb17ae"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c29537bd-68e7-43b3-9d59-665df7994846"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("ced64b94-0a55-4261-9768-8d2642c4b31f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e05fe524-6151-47e9-b657-6bdfd17e9878"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("1c35de5b-66d7-4c8e-a465-a7cbb0ae64f7"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("61c3f4af-fd76-483b-a25f-d5b8f57dcf92"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("66f0cff2-d913-4827-bf60-ed3e6d10b758"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("9cd2a7dc-e207-4e3a-b2cd-1a54d88bf259"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { new Guid("207e4d2a-eafe-4316-a202-d7d3df1140c0"), "ASICS" },
                    { new Guid("4af8a6a4-81fa-4427-a81e-0e00322f8c96"), "CONVERSE" },
                    { new Guid("80a90a7f-7913-489c-9b8b-79d9a9bfb979"), "VANS" },
                    { new Guid("384d303b-fe21-470a-a11f-24a33e3e2ca1"), "NIKE" }
                });

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "Name" },
                values: new object[,]
                {
                    { new Guid("356cda4b-58ba-4630-b739-8881d52ca0db"), "Sports" },
                    { new Guid("959dc696-56cf-4b92-a3a9-c1924b635909"), "Casual" },
                    { new Guid("e0f930c0-e041-41ad-bffb-109acfd83f31"), "Skate" },
                    { new Guid("6a635ea3-97b6-4892-8153-6b8d63ac28d3"), "Diner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("207e4d2a-eafe-4316-a202-d7d3df1140c0"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("384d303b-fe21-470a-a11f-24a33e3e2ca1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4af8a6a4-81fa-4427-a81e-0e00322f8c96"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("80a90a7f-7913-489c-9b8b-79d9a9bfb979"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("356cda4b-58ba-4630-b739-8881d52ca0db"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("6a635ea3-97b6-4892-8153-6b8d63ac28d3"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("959dc696-56cf-4b92-a3a9-c1924b635909"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("e0f930c0-e041-41ad-bffb-109acfd83f31"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { new Guid("8a0ec09e-c95a-4742-a110-1479f4fb17ae"), "ASICS" },
                    { new Guid("ced64b94-0a55-4261-9768-8d2642c4b31f"), "CONVERSE" },
                    { new Guid("e05fe524-6151-47e9-b657-6bdfd17e9878"), "VANS" },
                    { new Guid("c29537bd-68e7-43b3-9d59-665df7994846"), "NIKE" }
                });

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "Name" },
                values: new object[,]
                {
                    { new Guid("61c3f4af-fd76-483b-a25f-d5b8f57dcf92"), "Sports" },
                    { new Guid("1c35de5b-66d7-4c8e-a465-a7cbb0ae64f7"), "Casual" },
                    { new Guid("9cd2a7dc-e207-4e3a-b2cd-1a54d88bf259"), "Skate" },
                    { new Guid("66f0cff2-d913-4827-bf60-ed3e6d10b758"), "Diner" }
                });
        }
    }
}
