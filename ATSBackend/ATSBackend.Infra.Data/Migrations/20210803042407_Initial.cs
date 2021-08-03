using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATSBackend.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_curriculo",
                columns: table => new
                {
                    IdCurriculo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    formacao_academica = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_curriculo", x => x.IdCurriculo);
                });

            migrationBuilder.CreateTable(
                name: "tb_vaga",
                columns: table => new
                {
                    IdVaga = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Profissao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Encerrada = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Local = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_vaga", x => x.IdVaga);
                });

            migrationBuilder.CreateTable(
                name: "tb_candidato",
                columns: table => new
                {
                    IdCandidato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true),
                    Profissao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCurriculo = table.Column<int>(type: "int", nullable: false),
                    IdVaga = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_candidato", x => x.IdCandidato);
                    table.ForeignKey(
                        name: "FK_tb_candidato_tb_curriculo_IdCurriculo",
                        column: x => x.IdCurriculo,
                        principalTable: "tb_curriculo",
                        principalColumn: "IdCurriculo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_experiencia",
                columns: table => new
                {
                    IdExperiencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_empresa = table.Column<string>(type: "varchar(100)", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCurriculo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_experiencia", x => x.IdExperiencia);
                    table.ForeignKey(
                        name: "FK_tb_experiencia_tb_curriculo_IdCurriculo",
                        column: x => x.IdCurriculo,
                        principalTable: "tb_curriculo",
                        principalColumn: "IdCurriculo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_candidato_IdCurriculo",
                table: "tb_candidato",
                column: "IdCurriculo");

            migrationBuilder.CreateIndex(
                name: "IX_tb_experiencia_IdCurriculo",
                table: "tb_experiencia",
                column: "IdCurriculo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_candidato");

            migrationBuilder.DropTable(
                name: "tb_experiencia");

            migrationBuilder.DropTable(
                name: "tb_vaga");

            migrationBuilder.DropTable(
                name: "tb_curriculo");
        }
    }
}
