using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_herhaling_sneakers.Migrations
{
    public partial class feedbackdieter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

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

            migrationBuilder.CreateTable(
                name: "Occasions",
                columns: table => new
                {
                    OccasionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occasions", x => x.OccasionId);
                });

            migrationBuilder.CreateTable(
                name: "Sneakers",
                columns: table => new
                {
                    SneakerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sneakers", x => x.SneakerId);
                });

            migrationBuilder.CreateTable(
                name: "SneakerOccasions",
                columns: table => new
                {
                    SneakerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OccasionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SneakerOccasions", x => new { x.SneakerId, x.OccasionId });
                    table.ForeignKey(
                        name: "FK_SneakerOccasions_Occasions_OccasionId",
                        column: x => x.OccasionId,
                        principalTable: "Occasions",
                        principalColumn: "OccasionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SneakerOccasions_Sneakers_SneakerId",
                        column: x => x.SneakerId,
                        principalTable: "Sneakers",
                        principalColumn: "SneakerId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SneakerOccasions_OccasionId",
                table: "SneakerOccasions",
                column: "OccasionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "SneakerOccasions");

            migrationBuilder.DropTable(
                name: "Occasions");

            migrationBuilder.DropTable(
                name: "Sneakers");
        }
    }
}
