using Microsoft.EntityFrameworkCore.Migrations;

namespace Oyunlar.Migrations
{
    public partial class ekle5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "resim",
                table: "Oyuns",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "resim",
                table: "Oyuns");
        }
    }
}
