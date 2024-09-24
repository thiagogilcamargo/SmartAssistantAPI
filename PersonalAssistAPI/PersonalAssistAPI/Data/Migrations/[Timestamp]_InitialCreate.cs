using Microsoft.EntityFrameworkCore.Migrations;

public partial class InitialCreate : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Empresas",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Nome = table.Column<string>(nullable: false),
                Cnpj = table.Column<string>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Empresas", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Feedbacks",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                EmpresaId = table.Column<int>(nullable: false),
                Comentario = table.Column<string>(nullable: false),
                Avaliacao = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Feedbacks", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Servicos",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Nome = table.Column<string>(nullable: false),
                Descricao = table.Column<string>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Servicos", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Suportes",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                ServicoId = table.Column<int>(nullable: false),
                Mensagem = table.Column<string>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Suportes", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(name: "Empresas");
        migrationBuilder.DropTable(name: "Feedbacks");
        migrationBuilder.DropTable(name: "Servicos");
        migrationBuilder.DropTable(name: "Suportes");
    }
}
