using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Artigo
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Titulo { get; set; }

        [Required]
        public string Conteudo { get; set; }

        public string Imagem { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeAutor { get; set; }

        public bool Validado { get; set; }

        public DateTime? DataValidacao { get; set; }

        public string Tipo { get; set; }

        [ForeignKey("Utilizador")]
        public int UtilizadorID { get; set; }
        public Utilizador UtilArtigo { get; set; }
    }
}
