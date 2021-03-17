using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend_herhaling_sneakers.Migrations
{
    public partial class init : Migration
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
                name: "OccasionSneaker",
                columns: table => new
                {
                    OccasionsOccasionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SneakersSneakerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OccasionSneaker", x => new { x.OccasionsOccasionId, x.SneakersSneakerId });
                    table.ForeignKey(
                        name: "FK_OccasionSneaker_Occasions_OccasionsOccasionId",
                        column: x => x.OccasionsOccasionId,
                        principalTable: "Occasions",
                        principalColumn: "OccasionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OccasionSneaker_Sneakers_SneakersSneakerId",
                        column: x => x.SneakersSneakerId,
                        principalTable: "Sneakers",
                        principalColumn: "SneakerId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OccasionSneaker_SneakersSneakerId",
                table: "OccasionSneaker",
                column: "SneakersSneakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "OccasionSneaker");

            migrationBuilder.DropTable(
                name: "Occasions");

            migrationBuilder.DropTable(
                name: "Sneakers");
        }
    }
}
