using Microsoft.EntityFrameworkCore.Migrations;

namespace Oyunlar.Migrations
{
    public partial class deneme1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    adminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.adminID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    kullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.kullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "Oyuns",
                columns: table => new
                {
                    oyunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    oyunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    boyut = table.Column<int>(type: "int", nullable: false),
                    puan = table.Column<int>(type: "int", nullable: false),
                    yayinlamaTarihi = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuns", x => x.oyunID);
                    table.ForeignKey(
                        name: "FK_Oyuns_Kategoris_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Degerlendirmes",
                columns: table => new
                {
                    degerlendirmeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    puan = table.Column<int>(type: "int", nullable: false),
                    yorum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    oyunID = table.Column<int>(type: "int", nullable: false),
                    kullaniciID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degerlendirmes", x => x.degerlendirmeID);
                    table.ForeignKey(
                        name: "FK_Degerlendirmes_Kullanicis_kullaniciID",
                        column: x => x.kullaniciID,
                        principalTable: "Kullanicis",
                        principalColumn: "kullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Degerlendirmes_Oyuns_oyunID",
                        column: x => x.oyunID,
                        principalTable: "Oyuns",
                        principalColumn: "oyunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirmes_kullaniciID",
                table: "Degerlendirmes",
                column: "kullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Degerlendirmes_oyunID",
                table: "Degerlendirmes",
                column: "oyunID");

            migrationBuilder.CreateIndex(
                name: "IX_Oyuns_KategoriID",
                table: "Oyuns",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Degerlendirmes");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Oyuns");

            migrationBuilder.DropTable(
                name: "Kategoris");
        }
    }
}
