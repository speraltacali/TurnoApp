using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TA.Infraestrucuture.Context.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    EstaEliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuit = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    InicioActividad = table.Column<DateTime>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Imagen = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pais",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaTurno = table.Column<DateTime>(nullable: false),
                    Dia = table.Column<DateTime>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Ocupado = table.Column<bool>(nullable: false),
                    CancelacionEmpresa = table.Column<bool>(nullable: false),
                    EmpresaId = table.Column<long>(nullable: false),
                    CategoriaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turno_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Turno_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Provincia",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    PaisId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provincia_Pais_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Bloqueado = table.Column<bool>(nullable: false),
                    PerfilId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    ProvinciaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table_Provincia_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Empresa",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<long>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Empresa_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Empresa_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calle = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Manzana = table.Column<string>(nullable: true),
                    Piso = table.Column<string>(nullable: true),
                    NumDepartamento = table.Column<int>(nullable: false),
                    LocalidadId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domicilio_Table_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Dni = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Telefono = table.Column<string>(nullable: true),
                    Imagen = table.Column<byte[]>(nullable: true),
                    DomicilioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Domicilio_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empresa_Domicilio",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpresaId = table.Column<long>(nullable: false),
                    DomicilioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa_Domicilio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Domicilio_Domicilio_DomicilioId",
                        column: x => x.DomicilioId,
                        principalTable: "Domicilio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresa_Domicilio_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserva_Turno",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurnoId = table.Column<long>(nullable: false),
                    ClienteId = table.Column<long>(nullable: false),
                    FechaReserva = table.Column<DateTime>(nullable: false),
                    Confirmacion = table.Column<bool>(nullable: false),
                    CancelacionTurno = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva_Turno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserva_Turno_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_Turno_Turno_TurnoId",
                        column: x => x.TurnoId,
                        principalTable: "Turno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Cliente",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<long>(nullable: false),
                    UsuarioId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Cliente_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Cliente_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_DomicilioId",
                table: "Cliente",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_LocalidadId",
                table: "Domicilio",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_Domicilio_DomicilioId",
                table: "Empresa_Domicilio",
                column: "DomicilioId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_Domicilio_EmpresaId",
                table: "Empresa_Domicilio",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Provincia_PaisId",
                table: "Provincia",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Turno_ClienteId",
                table: "Reserva_Turno",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Turno_TurnoId",
                table: "Reserva_Turno",
                column: "TurnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Table_ProvinciaId",
                table: "Table",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_CategoriaId",
                table: "Turno",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_EmpresaId",
                table: "Turno",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cliente_ClienteId",
                table: "User_Cliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Cliente_UsuarioId",
                table: "User_Cliente",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Empresa_EmpresaId",
                table: "User_Empresa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Empresa_UsuarioId",
                table: "User_Empresa",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilId",
                table: "Usuario",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa_Domicilio");

            migrationBuilder.DropTable(
                name: "Reserva_Turno");

            migrationBuilder.DropTable(
                name: "User_Cliente");

            migrationBuilder.DropTable(
                name: "User_Empresa");

            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Domicilio");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "Provincia");

            migrationBuilder.DropTable(
                name: "Pais");
        }
    }
}
