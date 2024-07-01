using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Autor : Utilizador
    {
        public Autor() {
            ListaArtigo = new HashSet<Artigo>();
        }

        [Key]
        public int idAutor { get; set; }

        [ForeignKey(nameof(ArtigoPub))]
        public string ArtigoPubFK { get; set; }
        public Artigo ArtigoPub { get; set; }

        public ICollection<Artigo> ListaArtigo { get; set; }
    }
}
