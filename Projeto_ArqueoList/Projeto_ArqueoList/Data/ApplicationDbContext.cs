using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_ArqueoList.Models;

namespace Projeto_ArqueoList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet <Utilizador> Utilizador {  get; set; }

        public DbSet <Administrador> Administradores { get; set; }
            
        public DbSet <Utente> Utentes { get; set; }

        public DbSet <Autor> Autores { get; set; }

        public DbSet <Artigo> Artigos { get; set; }

        public DbSet <Tag> Tags { get; set; }

        public DbSet <Validacao> Validacao { get; set; }

        public DbSet <Artigo_Tag> ArtigoTags { get; set; }

    }
}
