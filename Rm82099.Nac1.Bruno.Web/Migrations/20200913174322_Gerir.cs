using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rm82099.Nac1.Bruno.Web.Migrations
{
    public partial class Gerir : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Mercado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    Capacidade = table.Column<int>(nullable: false),
                    Novo = table.Column<bool>(nullable: false),
                    Porte = table.Column<int>(nullable: false),
                    DataAbertura = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Mercado", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Mercado");
        }
    }
}
