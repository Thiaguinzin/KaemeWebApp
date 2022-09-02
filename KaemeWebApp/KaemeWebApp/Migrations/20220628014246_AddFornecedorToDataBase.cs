using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KaemeWebApp.Migrations
{
    public partial class AddFornecedorToDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "varchar(100)", nullable: false),
                    minPedidoAtacado = table.Column<decimal>(type: "money", nullable: true),
                    FreteStatusId = table.Column<int>(type: "int", nullable: false),
                    percDescAVista = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: true),
                    Instagram = table.Column<string>(type: "varchar(100)", nullable: true),
                    Contato = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_FreteStatus_FreteStatusId",
                        column: x => x.FreteStatusId,
                        principalTable: "FreteStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_FreteStatusId",
                table: "Fornecedor",
                column: "FreteStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
