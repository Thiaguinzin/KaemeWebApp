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
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    minPedidoAtacado = table.Column<decimal>(type: "money", nullable: false),
                    FreteStatusId = table.Column<int>(type: "int", nullable: false),
                    percDescAVista = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contato = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
