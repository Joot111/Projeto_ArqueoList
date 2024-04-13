using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class R1
    {
        [ForeignKey (nameof(Utente))]
        public int idUser { get; set; }
        public Utente Utente { get; set; }

        [Key, ForeignKey(nameof(ArtPriv))]
        public int idArtigo { get; set; }
        public Artigo_Privado ArtPriv { get; set; }
    }
}
