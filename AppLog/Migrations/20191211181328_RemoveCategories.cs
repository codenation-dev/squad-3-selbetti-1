using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLog.Migrations
{
    public partial class RemoveCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Categories_CategoryId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Environments_EnvironmentId",
                table: "Logs");

            migrationBuilder.DropTable(
                name: "ApplicationsCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Logs_CategoryId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Logs");

            migrationBuilder.AlterColumn<int>(
                name: "EnvironmentId",
                table: "Logs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Environments_EnvironmentId",
                table: "Logs",
                column: "EnvironmentId",
                principalTable: "Environments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Environments_EnvironmentId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Logs");

            migrationBuilder.AlterColumn<int>(
                name: "EnvironmentId",
                table: "Logs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Logs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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
                name: "IX_Logs_CategoryId",
                table: "Logs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationsCategories_CategoryId",
                table: "ApplicationsCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Categories_CategoryId",
                table: "Logs",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Environments_EnvironmentId",
                table: "Logs",
                column: "EnvironmentId",
                principalTable: "Environments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
