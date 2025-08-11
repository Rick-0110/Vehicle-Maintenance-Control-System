using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeControleVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quilomentragem",
                table: "Veiculos",
                newName: "Quilometragem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quilometragem",
                table: "Veiculos",
                newName: "Quilomentragem");
        }
    }
}
