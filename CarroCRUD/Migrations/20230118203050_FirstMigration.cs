using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarroCRUD.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carro_Marca_MarcaId",
                table: "Carro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Marca",
                table: "Marca");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carro",
                table: "Carro");

            migrationBuilder.RenameTable(
                name: "Marca",
                newName: "marcas");

            migrationBuilder.RenameTable(
                name: "Carro",
                newName: "carros");

            migrationBuilder.RenameIndex(
                name: "IX_Carro_MarcaId",
                table: "carros",
                newName: "IX_carros_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_marcas",
                table: "marcas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carros",
                table: "carros",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_carros_marcas_MarcaId",
                table: "carros",
                column: "MarcaId",
                principalTable: "marcas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carros_marcas_MarcaId",
                table: "carros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_marcas",
                table: "marcas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carros",
                table: "carros");

            migrationBuilder.RenameTable(
                name: "marcas",
                newName: "Marca");

            migrationBuilder.RenameTable(
                name: "carros",
                newName: "Carro");

            migrationBuilder.RenameIndex(
                name: "IX_carros_MarcaId",
                table: "Carro",
                newName: "IX_Carro_MarcaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Marca",
                table: "Marca",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carro",
                table: "Carro",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carro_Marca_MarcaId",
                table: "Carro",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
