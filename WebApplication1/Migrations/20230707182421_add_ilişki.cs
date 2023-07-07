using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class add_ilişki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departid",
                table: "Personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_departid",
                table: "Personels",
                column: "departid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmanlars_departid",
                table: "Personels",
                column: "departid",
                principalTable: "Departmanlars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmanlars_departid",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_departid",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "departid",
                table: "Personels");
        }
    }
}
