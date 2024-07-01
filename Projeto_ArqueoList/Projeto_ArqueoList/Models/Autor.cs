using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Autor : Utilizador
    {
        public Autor() {
            ListaArtigo = new HashSet<Artigo>();
        }

        public int idAutor { get; set; }

        public ICollection<Artigo> ListaArtigo { get; set; }
    }
}
