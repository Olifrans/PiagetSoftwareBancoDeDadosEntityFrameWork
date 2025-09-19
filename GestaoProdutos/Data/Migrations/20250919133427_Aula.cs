using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoProdutos.Data.Migrations
{
    /// <inheritdoc />
    public partial class Aula : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeDoProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoDoProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodigoDoProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrecoDoProduto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
