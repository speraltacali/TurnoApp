using Microsoft.EntityFrameworkCore.Migrations;

namespace TA.Infraestrucuture.Context.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_Table_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_Provincia_ProvinciaId",
                table: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Localidad");

            migrationBuilder.RenameIndex(
                name: "IX_Table_ProvinciaId",
                table: "Localidad",
                newName: "IX_Localidad_ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localidad",
                table: "Localidad",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_Localidad_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId",
                principalTable: "Localidad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Localidad_Provincia_ProvinciaId",
                table: "Localidad",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Domicilio_Localidad_LocalidadId",
                table: "Domicilio");

            migrationBuilder.DropForeignKey(
                name: "FK_Localidad_Provincia_ProvinciaId",
                table: "Localidad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localidad",
                table: "Localidad");

            migrationBuilder.RenameTable(
                name: "Localidad",
                newName: "Table");

            migrationBuilder.RenameIndex(
                name: "IX_Localidad_ProvinciaId",
                table: "Table",
                newName: "IX_Table_ProvinciaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Domicilio_Table_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId",
                principalTable: "Table",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Provincia_ProvinciaId",
                table: "Table",
                column: "ProvinciaId",
                principalTable: "Provincia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
