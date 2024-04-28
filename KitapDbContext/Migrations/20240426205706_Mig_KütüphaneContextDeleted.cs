using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitap.arama.Migrations
{
    /// <inheritdoc />
    public partial class Mig_KütüphaneContextDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdı = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KitapKategori = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Müşteris",
                columns: table => new
                {
                    MüşteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MüşteriAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MüşteriSoyAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KiralananKitapSayısı = table.Column<int>(type: "int", nullable: false),
                    OkunanKitapSayısı = table.Column<int>(type: "int", nullable: false),
                    KiralananKitaplar = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Müşteris", x => x.MüşteriID);
                });

            migrationBuilder.CreateTable(
                name: "Subes",
                columns: table => new
                {
                    ŞubeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ŞubeUlke = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ŞubeMahalle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ŞubeKpaıNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ŞubeSokak = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subes", x => x.ŞubeID);
                });

            migrationBuilder.CreateTable(
                name: "Worders",
                columns: table => new
                {
                    WorkerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkerSurName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WorkerDepertmant = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worders", x => x.WorkerID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Müşteris");

            migrationBuilder.DropTable(
                name: "Subes");

            migrationBuilder.DropTable(
                name: "Worders");
        }
    }
}
