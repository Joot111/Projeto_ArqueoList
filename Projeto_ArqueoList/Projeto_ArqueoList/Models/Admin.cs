using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Admin : Utilizador
    {
        [ForeignKey(nameof(ArtigoEsp))]
        public int ArtigoEspFK { get; set; }
        public Artigo_Em_Espera ArtigoEsp { get; set; }

        [ForeignKey(nameof(ArtigoPub))]
        public int ArtigoPubFK { get; set; }
        public Artigo_Publico ArtigoPub { get; set; }

        public ICollection<R3> R3 { get; }
    }
}
