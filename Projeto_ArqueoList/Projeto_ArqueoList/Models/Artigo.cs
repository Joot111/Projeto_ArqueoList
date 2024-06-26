﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Artigo
    {
        public Artigo() {
            ListaValidacao = new HashSet<Validacao>();
            ListaArtigoTags = new HashSet<Artigo_Tag>();
        }

        [Key]
        public int ID { get; set; }
        [StringLength(70)]
        public string Titulo { get; set; }
        [StringLength(5000)]
        public string Conteudo { get; set; }
        public string Imagem { get; set; }   
        [StringLength(50)]
        public string Nome_Autor { get; set; }
        public Boolean validado { get; set; }
        public DateOnly data_validacao { get; set; }
        [StringLength(50)]
        public string tipo {  get; set; }

        [ForeignKey(nameof(UtenteArtigo))]
        public int ID_Utente { get; set; }
        public Utente UtenteArtigo { get; set; }


        [ForeignKey(nameof(AdminArtigo))]
        public int ID_Administrador { get; set; }
        public Administrador AdminArtigo { get; set; }

        [ForeignKey(nameof(AutorArtigo))]
        public int ID_Autor { get; set; }
        public Autor AutorArtigo { get; set; }

        public ICollection<Validacao> ListaValidacao { get; set; }
        public ICollection<Artigo_Tag> ListaArtigoTags { get; set; }

    }

}
