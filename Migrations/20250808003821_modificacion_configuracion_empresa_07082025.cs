using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tipo_Datos.Migrations
{
    /// <inheritdoc />
    public partial class modificacion_configuracion_empresa_07082025 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contrasenia",
                table: "ConfiguracionesEmpresa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contrasenia",
                table: "ConfiguracionesEmpresa");
        }
    }
}
