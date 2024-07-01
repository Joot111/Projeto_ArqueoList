using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Utente : Utilizador
    {
        public Utente() {
            ListaArtigo = new HashSet<Artigo>();
        }

        public int idUtente { get; set; }

        public ICollection<Artigo> ListaArtigo { get; set; }
    }
}
