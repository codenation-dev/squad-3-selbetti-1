using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLog.Migrations
{
    public partial class app : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Environments_EnviromentId",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "EnviromentId",
                table: "Logs",
                newName: "EnvironmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_EnviromentId",
                table: "Logs",
                newName: "IX_Logs_EnvironmentId");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Users_UserId",
                table: "Applications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Environments_EnvironmentId",
                table: "Logs",
                column: "EnvironmentId",
                principalTable: "Environments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Users_UserId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Environments_EnvironmentId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Applications_UserId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "EnvironmentId",
                table: "Logs",
                newName: "EnviromentId");

            migrationBuilder.RenameIndex(
                name: "IX_Logs_EnvironmentId",
                table: "Logs",
                newName: "IX_Logs_EnviromentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Environments_EnviromentId",
                table: "Logs",
                column: "EnviromentId",
                principalTable: "Environments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
