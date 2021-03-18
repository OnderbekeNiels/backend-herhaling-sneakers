using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_herhaling_sneakers.Migrations
{
    public partial class toevoegelistimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("124fd704-c95f-491e-8830-afb2ea306efd"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("48881100-82b9-4093-8937-a420e8d20451"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("6be65aa1-b05e-4bbd-9cf9-d7965aae3b6b"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c92fabe2-ef96-4cfa-9ce4-824b85c4a5bf"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("4c3d4523-5cbb-45b2-ac13-a66efe04a177"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("593ff6f2-d6d5-4a68-8a56-0724eca02e92"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("9fd2a7a0-ffbe-49d4-b79a-2539e37a7a7a"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("b4b949c9-2e78-45ef-bf3b-4a6e7f2c6afa"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { new Guid("4f3439de-8ec0-4486-8204-0b621a09642c"), "ASICS" },
                    { new Guid("79cf5795-56ed-44c6-8eec-7f792cc79813"), "CONVERSE" },
                    { new Guid("c9aa7ea5-5c10-4a01-aebd-4b796bf1e9b3"), "VANS" },
                    { new Guid("69ad5fa2-fa4a-4985-95c0-9b29be6cc0b7"), "NIKE" }
                });

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "Name" },
                values: new object[,]
                {
                    { new Guid("66140e8a-fa09-443b-bfd7-8546f5f095d0"), "Sports" },
                    { new Guid("b60ddfce-fd93-4717-8180-1253360da255"), "Casual" },
                    { new Guid("3249dad1-c967-443a-b5ae-a66b7b1b18cd"), "Skate" },
                    { new Guid("fdd022c7-d484-433d-a2b8-5518d5a37858"), "Diner" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_SneakerId",
                table: "Images",
                column: "SneakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Sneakers_SneakerId",
                table: "Images",
                column: "SneakerId",
                principalTable: "Sneakers",
                principalColumn: "SneakerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Sneakers_SneakerId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_SneakerId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("4f3439de-8ec0-4486-8204-0b621a09642c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("69ad5fa2-fa4a-4985-95c0-9b29be6cc0b7"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("79cf5795-56ed-44c6-8eec-7f792cc79813"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: new Guid("c9aa7ea5-5c10-4a01-aebd-4b796bf1e9b3"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("3249dad1-c967-443a-b5ae-a66b7b1b18cd"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("66140e8a-fa09-443b-bfd7-8546f5f095d0"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("b60ddfce-fd93-4717-8180-1253360da255"));

            migrationBuilder.DeleteData(
                table: "Occasions",
                keyColumn: "OccasionId",
                keyValue: new Guid("fdd022c7-d484-433d-a2b8-5518d5a37858"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Name" },
                values: new object[,]
                {
                    { new Guid("6be65aa1-b05e-4bbd-9cf9-d7965aae3b6b"), "ASICS" },
                    { new Guid("124fd704-c95f-491e-8830-afb2ea306efd"), "CONVERSE" },
                    { new Guid("48881100-82b9-4093-8937-a420e8d20451"), "VANS" },
                    { new Guid("c92fabe2-ef96-4cfa-9ce4-824b85c4a5bf"), "NIKE" }
                });

            migrationBuilder.InsertData(
                table: "Occasions",
                columns: new[] { "OccasionId", "Name" },
                values: new object[,]
                {
                    { new Guid("593ff6f2-d6d5-4a68-8a56-0724eca02e92"), "Sports" },
                    { new Guid("4c3d4523-5cbb-45b2-ac13-a66efe04a177"), "Casual" },
                    { new Guid("9fd2a7a0-ffbe-49d4-b79a-2539e37a7a7a"), "Skate" },
                    { new Guid("b4b949c9-2e78-45ef-bf3b-4a6e7f2c6afa"), "Diner" }
                });
        }
    }
}
