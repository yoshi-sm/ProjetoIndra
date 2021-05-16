using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manutencao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    ProximaManutencao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(20)", nullable: false),
                    Ano = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cor = table.Column<string>(type: "varchar(20)", nullable: false),
                    Placa = table.Column<string>(type: "varchar(20)", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carro_Marca_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgendaManutencao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdManutencao = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "date", nullable: false),
                    IdCarro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaManutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AgendaManutencao_Carro_IdCarro",
                        column: x => x.IdCarro,
                        principalTable: "Carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgendaManutencao_Manutencao_IdManutencao",
                        column: x => x.IdManutencao,
                        principalTable: "Manutencao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroManutencao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quilometragem = table.Column<int>(type: "int", nullable: false),
                    IdManutencao = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "date", nullable: false),
                    IdCarro = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroManutencao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroManutencao_Carro_IdCarro",
                        column: x => x.IdCarro,
                        principalTable: "Carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistroManutencao_Manutencao_IdManutencao",
                        column: x => x.IdManutencao,
                        principalTable: "Manutencao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgendaManutencao_IdCarro",
                table: "AgendaManutencao",
                column: "IdCarro");

            migrationBuilder.CreateIndex(
                name: "IX_AgendaManutencao_IdManutencao",
                table: "AgendaManutencao",
                column: "IdManutencao");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_IdMarca",
                table: "Carro",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroManutencao_IdCarro",
                table: "RegistroManutencao",
                column: "IdCarro");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroManutencao_IdManutencao",
                table: "RegistroManutencao",
                column: "IdManutencao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaManutencao");

            migrationBuilder.DropTable(
                name: "RegistroManutencao");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Manutencao");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
