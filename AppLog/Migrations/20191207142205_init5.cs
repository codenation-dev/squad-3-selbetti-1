using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLog.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationsCategories",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    RequireSolution = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationsCategories", x => new { x.ApplicationId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ApplicationsCategories_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationsCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsCategories_CategoryId",
                table: "ApplicationsCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationsCategories");
        }
    }
}
