using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Utente : Utilizador
    {
        public Utente() {
            R1 = new HashSet<R1>();
        }

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
