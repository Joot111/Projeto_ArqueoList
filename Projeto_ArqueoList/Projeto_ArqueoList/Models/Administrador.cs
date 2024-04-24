using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Administrador
    {
        public Administrador() {
            ListaArtigo = new HashSet<Artigo>();
            ListaValidacao = new HashSet<Validacao>();
        }

        [Key]
        public int idAdmin { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateOnly Data_Nascimento { get; set; }

        public ICollection <Artigo> ListaArtigo { get; set; }
        public ICollection<Validacao> ListaValidacao { get; set; }
    }
}
