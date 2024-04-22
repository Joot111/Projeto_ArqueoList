using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Utente
    {
        public Utente() {
            R1 = new HashSet<R1>();
        }

        [Key]
        public int idUtente { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateOnly Data_Nascimento { get; set; }

        [ForeignKey(nameof(ArtigoPriv))]
        public string Nome_Autor { get; set; }
        public Artigo_Privado ArtigoPriv { get; set; }

        [ForeignKey(nameof(ArtigoEsp))]
        public string Nome_Autor2 { get; set; }
        public Artigo_Em_Espera ArtigoEsp { get; set; }

        public ICollection<R1> R1 { get; set; }

        public ICollection<R2> R2 { get;}
    }
}
