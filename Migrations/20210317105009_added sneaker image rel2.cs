using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_herhaling_sneakers.Migrations
{
    public partial class addedsneakerimagerel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SneakerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { new Guid("f13ad2f3-563c-4318-974e-3385ba50fda1"), "ASICS" },
                    { new Guid("e0c717f2-847b-4f6b-9525-d636a7598a8b"), "CONVERSE" },
                    { new Guid("91da7bd3-d4e7-404e-b7b8-50a3f1e189c5"), "VANS" },
                    { new Guid("2bc8aa37-fadc-4705-b1c8-f92cac8e0e3b"), "NIKE" }
                });

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "Name" },
                values: new object[,]
                {
                    { new Guid("2d7a920f-0abd-4045-8d88-458c5502a7d5"), "Sports" },
                    { new Guid("9a2086cb-91a4-4c83-b709-50d4b097298e"), "Casual" },
                    { new Guid("878b4642-c653-4509-b914-4ba1d55e0fdb"), "Skate" },
                    { new Guid("2cc9fc43-4833-4d2d-840b-da889fdf67ae"), "Diner" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("2bc8aa37-fadc-4705-b1c8-f92cac8e0e3b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("91da7bd3-d4e7-404e-b7b8-50a3f1e189c5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("e0c717f2-847b-4f6b-9525-d636a7598a8b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("f13ad2f3-563c-4318-974e-3385ba50fda1"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("2cc9fc43-4833-4d2d-840b-da889fdf67ae"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("2d7a920f-0abd-4045-8d88-458c5502a7d5"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("878b4642-c653-4509-b914-4ba1d55e0fdb"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("9a2086cb-91a4-4c83-b709-50d4b097298e"));

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
    }
}
