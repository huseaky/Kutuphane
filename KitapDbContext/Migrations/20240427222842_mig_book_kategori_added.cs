using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitap.arama.Migrations
{
    /// <inheritdoc />
    public partial class mig_book_kategori_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KitapKategori",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "Kategori",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kategori",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "KitapKategori",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
