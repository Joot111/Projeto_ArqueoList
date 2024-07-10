using Microsoft.AspNetCore.Identity;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
            modelBuilder.Entity<Administrador>().ToTable("Administrador");
            modelBuilder.Entity<Utente>().ToTable("Utente");
            modelBuilder.Entity<Autor>().ToTable("Autor");
            modelBuilder.Entity<Utilizador>().ToTable("Utilizador");

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "adm", Name = "Admin", NormalizedName = "Administrador"}
                );
        }

    }
}
