using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoltAir.Migrations
{
    /// <inheritdoc />
    public partial class VoltAirV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    idMarca = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nomeMarca = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Marca__7033181270C60E6A", x => x.idMarca);
                });

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    idRegistro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UltimaRecarga = table.Column<DateTime>(type: "datetime", nullable: true),
                    DuracaoRecarga = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Registro__62FC8F58FCF1BD8A", x => x.idRegistro);
                });

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    idCarro = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idMarca = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    idRegistro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    modelo = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    placa = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DurBateria = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carros__3D09E20E3C025E74", x => x.idCarro);
                    table.ForeignKey(
                        name: "FK_Carros_Marca",
                        column: x => x.idMarca,
                        principalTable: "Marca",
                        principalColumn: "idMarca");
                    table.ForeignKey(
                        name: "FK_Carros_Registros",
                        column: x => x.idRegistro,
                        principalTable: "Registros",
                        principalColumn: "idRegistro");
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idCarro = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    nome = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    senha = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    foto = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuarios__645723A69BF397A7", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Carros",
                        column: x => x.idCarro,
                        principalTable: "Carros",
                        principalColumn: "idCarro");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carros_idMarca",
                table: "Carros",
                column: "idMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Carros_idRegistro",
                table: "Carros",
                column: "idRegistro");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_idCarro",
                table: "Usuarios",
                column: "idCarro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
