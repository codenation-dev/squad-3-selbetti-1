using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLog.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Enviroments_EnviromentId",
                table: "Logs");

            migrationBuilder.DropTable(
                name: "Environments");

            migrationBuilder.CreateTable(
                name: "Environments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ip = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    ApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Environments_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Environments_ApplicationId",
                table: "Environments",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Environments_EnviromentId",
                table: "Logs",
                column: "EnviromentId",
                principalTable: "Environments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Environments_EnviromentId",
                table: "Logs");

            migrationBuilder.DropTable(
                name: "Environments");

            migrationBuilder.CreateTable(
                name: "Environments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationId = table.Column<int>(nullable: true),
                    Ip = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enviroments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enviroments_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enviroments_ApplicationId",
                table: "Environments",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Enviroments_EnviromentId",
                table: "Logs",
                column: "EnviromentId",
                principalTable: "Environments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
