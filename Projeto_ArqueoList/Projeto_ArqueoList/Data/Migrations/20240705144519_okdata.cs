using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_ArqueoList.Data.Migrations
{
    /// <inheritdoc />
    public partial class okdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Utilizador_ID_Administrador",
                table: "Artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Utilizador_ID_Autor",
                table: "Artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Utilizador_ID_Utente",
                table: "Artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Validacao_Utilizador_ID_Administrador",
                table: "Validacao");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "idAdmin",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "idAutor",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "idUtente",
                table: "Utilizador");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Utilizador",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Artigos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    idUtilizador = table.Column<int>(type: "int", nullable: false),
                    idAdmin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrador", x => x.idUtilizador);
                    table.ForeignKey(
                        name: "FK_Administrador_Utilizador_idUtilizador",
                        column: x => x.idUtilizador,
                        principalTable: "Utilizador",
                        principalColumn: "idUtilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    idUtilizador = table.Column<int>(type: "int", nullable: false),
                    idAutor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.idUtilizador);
                    table.ForeignKey(
                        name: "FK_Autor_Utilizador_idUtilizador",
                        column: x => x.idUtilizador,
                        principalTable: "Utilizador",
                        principalColumn: "idUtilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utente",
                columns: table => new
                {
                    idUtilizador = table.Column<int>(type: "int", nullable: false),
                    idUtente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utente", x => x.idUtilizador);
                    table.ForeignKey(
                        name: "FK_Utente_Utilizador_idUtilizador",
                        column: x => x.idUtilizador,
                        principalTable: "Utilizador",
                        principalColumn: "idUtilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Administrador_ID_Administrador",
                table: "Artigos",
                column: "ID_Administrador",
                principalTable: "Administrador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Autor_ID_Autor",
                table: "Artigos",
                column: "ID_Autor",
                principalTable: "Autor",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Utente_ID_Utente",
                table: "Artigos",
                column: "ID_Utente",
                principalTable: "Utente",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Validacao_Administrador_ID_Administrador",
                table: "Validacao",
                column: "ID_Administrador",
                principalTable: "Administrador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Administrador_ID_Administrador",
                table: "Artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Autor_ID_Autor",
                table: "Artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Utente_ID_Utente",
                table: "Artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Validacao_Administrador_ID_Administrador",
                table: "Validacao");

            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Utente");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Utilizador",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Utilizador",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "idAdmin",
                table: "Utilizador",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idAutor",
                table: "Utilizador",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idUtente",
                table: "Utilizador",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Imagem",
                table: "Artigos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Utilizador_ID_Administrador",
                table: "Artigos",
                column: "ID_Administrador",
                principalTable: "Utilizador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Utilizador_ID_Autor",
                table: "Artigos",
                column: "ID_Autor",
                principalTable: "Utilizador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Utilizador_ID_Utente",
                table: "Artigos",
                column: "ID_Utente",
                principalTable: "Utilizador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Validacao_Utilizador_ID_Administrador",
                table: "Validacao",
                column: "ID_Administrador",
                principalTable: "Utilizador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
