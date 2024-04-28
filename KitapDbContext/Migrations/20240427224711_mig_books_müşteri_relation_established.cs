using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kitap.arama.Migrations
{
    /// <inheritdoc />
    public partial class mig_books_müşteri_relation_established : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KiralananKitaplar",
                table: "Müşteris");

            migrationBuilder.AddColumn<int>(
                name: "MüşteriID",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_MüşteriID",
                table: "Books",
                column: "MüşteriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Müşteris_MüşteriID",
                table: "Books",
                column: "MüşteriID",
                principalTable: "Müşteris",
                principalColumn: "MüşteriID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Müşteris_MüşteriID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_MüşteriID",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "MüşteriID",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "KiralananKitaplar",
                table: "Müşteris",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
