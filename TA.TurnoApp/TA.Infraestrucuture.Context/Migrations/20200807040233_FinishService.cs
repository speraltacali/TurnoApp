using Microsoft.EntityFrameworkCore.Migrations;

namespace TA.Infraestrucuture.Context.Migrations
{
    public partial class FinishService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Usuario",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Turno",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Perfil",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Eliminado",
                table: "Domicilio",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Turno");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "Eliminado",
                table: "Domicilio");
        }
    }
}
