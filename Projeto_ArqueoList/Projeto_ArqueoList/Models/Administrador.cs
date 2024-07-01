using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Administrador : Utilizador
    {
        public Administrador() {
            ListaArtigo = new HashSet<Artigo>();
            ListaValidacao = new HashSet<Validacao>();
        }

        public int idAdmin { get; set; }

        public ICollection <Artigo> ListaArtigo { get; set; }
        public ICollection<Validacao> ListaValidacao { get; set; }
    }
}
