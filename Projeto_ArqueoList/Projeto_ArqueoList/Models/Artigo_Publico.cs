using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Artigo_Publico
    {
        public Artigo_Publico() {
            ListaAutores = new HashSet<Autor>();
        }
        [Key]
        public int idArtigo { get; set; }
        [StringLength(70)]
        public string Titulo { get; set; }
        [StringLength(5000)]
        public string Texto { get; set; }
        public DateOnly Data { get; set; }
        [StringLength(50)]
        public string Nome_Autor { get; set; }
        public string Imagem { get; set; }
        public string Estado { get; set; }


        [ForeignKey(nameof(ArtigoEsp))]
        public int ArtigoEspFK { get; set; }
        public Artigo_Em_Espera ArtigoEsp { get; set; }

        public ICollection<Autor> ListaAutores { get; set; }
    }

}
