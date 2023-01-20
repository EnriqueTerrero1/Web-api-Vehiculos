using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarroCRUD.Migrations
{
    /// <inheritdoc />
    public partial class tablemodifi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "carros",
                newName: "año");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "carros",
                newName: "Costo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "año",
                table: "carros",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "Costo",
                table: "carros",
                newName: "Cost");
        }
    }
}
