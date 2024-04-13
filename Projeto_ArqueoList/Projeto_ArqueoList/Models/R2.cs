using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class R2
    {
        [ForeignKey(nameof(Utente))]
        public int idUser { get; set; }
        public Utente Utente { get; set; }

        [Key, ForeignKey(nameof(ArtEsp))]
        public int idArtigo { get; set; }
        public Artigo_Em_Espera ArtEsp { get; set; }
    }
}
