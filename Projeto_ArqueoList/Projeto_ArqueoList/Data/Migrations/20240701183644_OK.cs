﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_ArqueoList.Data.Migrations
{
    /// <inheritdoc />
    public partial class OK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID_Tag = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID_Tag);
                });

            migrationBuilder.CreateTable(
                name: "Utilizador",
                columns: table => new
                {
                    idUtilizador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    idAdmin = table.Column<int>(type: "int", nullable: true),
                    idAutor = table.Column<int>(type: "int", nullable: true),
                    idUtente = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizador", x => x.idUtilizador);
                });

            migrationBuilder.CreateTable(
                name: "Artigos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Imagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_Autor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    validado = table.Column<bool>(type: "bit", nullable: false),
                    data_validacao = table.Column<DateOnly>(type: "date", nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID_Utente = table.Column<int>(type: "int", nullable: false),
                    ID_Administrador = table.Column<int>(type: "int", nullable: false),
                    ID_Autor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artigos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Artigos_Utilizador_ID_Administrador",
                        column: x => x.ID_Administrador,
                        principalTable: "Utilizador",
                        principalColumn: "idUtilizador",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Artigos_Utilizador_ID_Autor",
                        column: x => x.ID_Autor,
                        principalTable: "Utilizador",
                        principalColumn: "idUtilizador",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Artigos_Utilizador_ID_Utente",
                        column: x => x.ID_Utente,
                        principalTable: "Utilizador",
                        principalColumn: "idUtilizador",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ArtigoTags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ID_Tag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtigoTags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArtigoTags_Artigos_ID",
                        column: x => x.ID,
                        principalTable: "Artigos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtigoTags_Tags_ID_Tag",
                        column: x => x.ID_Tag,
                        principalTable: "Tags",
                        principalColumn: "ID_Tag",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Validacao",
                columns: table => new
                {
                    ID_Validacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    data_validacao = table.Column<DateOnly>(type: "date", nullable: false),
                    ID_Artigo = table.Column<int>(type: "int", nullable: false),
                    ID_Administrador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Validacao", x => x.ID_Validacao);
                    table.ForeignKey(
                        name: "FK_Validacao_Artigos_ID_Artigo",
                        column: x => x.ID_Artigo,
                        principalTable: "Artigos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Validacao_Utilizador_ID_Administrador",
                        column: x => x.ID_Administrador,
                        principalTable: "Utilizador",
                        principalColumn: "idUtilizador",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_ID_Administrador",
                table: "Artigos",
                column: "ID_Administrador");

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_ID_Autor",
                table: "Artigos",
                column: "ID_Autor");

            migrationBuilder.CreateIndex(
                name: "IX_Artigos_ID_Utente",
                table: "Artigos",
                column: "ID_Utente");

            migrationBuilder.CreateIndex(
                name: "IX_ArtigoTags_ID_Tag",
                table: "ArtigoTags",
                column: "ID_Tag");

            migrationBuilder.CreateIndex(
                name: "IX_Validacao_ID_Administrador",
                table: "Validacao",
                column: "ID_Administrador");

            migrationBuilder.CreateIndex(
                name: "IX_Validacao_ID_Artigo",
                table: "Validacao",
                column: "ID_Artigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtigoTags");

            migrationBuilder.DropTable(
                name: "Validacao");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Artigos");

            migrationBuilder.DropTable(
                name: "Utilizador");
        }
    }
}
