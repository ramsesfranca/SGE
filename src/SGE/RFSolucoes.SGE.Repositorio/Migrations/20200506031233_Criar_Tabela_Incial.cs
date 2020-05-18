using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace RFSolucoes.SGE.Repositorio.Migrations
{
    public partial class Criar_Tabela_Incial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Produtos",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraCadastro = table.Column<DateTime>("datetime", nullable: false),
                    DataHoraModificado = table.Column<DateTime>("datetime", nullable: true),
                    Nome = table.Column<string>("varchar(250)", nullable: false),
                    CodigoInterno = table.Column<string>("varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Produtos");
        }
    }
}
