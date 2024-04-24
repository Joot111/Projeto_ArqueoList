using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Utente
    {
        public Utente() {
            ListaArtigo = new HashSet<Artigo>();
        }

        [Key]
        public int idUtente { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateOnly Data_Nascimento { get; set; }

        public ICollection<Artigo> ListaArtigo { get; set; }
    }
}
