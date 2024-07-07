using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_ArqueoList.Data.Migrations
{
    /// <inheritdoc />
    public partial class artigodate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Artigos_ID_Administrador",
                table: "Artigos");

            migrationBuilder.DropIndex(
                name: "IX_Artigos_ID_Autor",
                table: "Artigos");

            migrationBuilder.DropColumn(
                name: "ID_Administrador",
                table: "Artigos");

            migrationBuilder.DropColumn(
                name: "ID_Autor",
                table: "Artigos");

            migrationBuilder.RenameColumn(
                name: "ID_Utente",
                table: "Artigos",
                newName: "ID_Utilizador");

            migrationBuilder.RenameIndex(
                name: "IX_Artigos_ID_Utente",
                table: "Artigos",
                newName: "IX_Artigos_ID_Utilizador");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data_Nascimento",
                table: "Utilizador",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "data_validacao",
                table: "Artigos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Utilizador_ID_Utilizador",
                table: "Artigos",
                column: "ID_Utilizador",
                principalTable: "Utilizador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artigos_Utilizador_ID_Utilizador",
                table: "Artigos");

            migrationBuilder.RenameColumn(
                name: "ID_Utilizador",
                table: "Artigos",
                newName: "ID_Utente");

            migrationBuilder.RenameIndex(
                name: "IX_Artigos_ID_Utilizador",
                table: "Artigos",
                newName: "IX_Artigos_ID_Utente");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Data_Nascimento",
                table: "Utilizador",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "data_validacao",
                table: "Artigos",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ID_Administrador",
                table: "Artigos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Autor",
                table: "Artigos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_ID_Administrador",
                table: "Artigos",
                column: "ID_Administrador");

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_ID_Autor",
                table: "Artigos",
                column: "ID_Autor");

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Administrador_ID_Administrador",
                table: "Artigos",
                column: "ID_Administrador",
                principalTable: "Administrador",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Autor_ID_Autor",
                table: "Artigos",
                column: "ID_Autor",
                principalTable: "Autor",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artigos_Utente_ID_Utente",
                table: "Artigos",
                column: "ID_Utente",
                principalTable: "Utente",
                principalColumn: "idUtilizador",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
