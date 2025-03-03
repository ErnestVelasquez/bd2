using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bd11.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Alumnos",
                newName: "Carnet");

            migrationBuilder.AddColumn<int>(
                name: "CantidadMateria",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ciclo",
                table: "Alumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadMateria",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "Ciclo",
                table: "Alumnos");

            migrationBuilder.RenameColumn(
                name: "Carnet",
                table: "Alumnos",
                newName: "NombreCompleto");
        }
    }
}
