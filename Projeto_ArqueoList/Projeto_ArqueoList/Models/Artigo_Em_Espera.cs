using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Artigo_Em_Espera
    {
        public Artigo_Em_Espera()
        {
            R2 = new HashSet<R2>();
            R3 = new HashSet<R3>();
        }
        [Key]
        public int idArtigo { get; set; }
        [StringLength(70)]
        public string Titulo { get; set; }
        [StringLength(5000)]
        public string Texto { get; set; }
        public DateOnly Data { get; set; }
        [StringLength(50)]
        public string Nome_Autor { get; set; }
        [StringLength(50)]
        public string Imagem { get; set; }
        public string Estado { get; set; }


        [ForeignKey(nameof(ArtigoPriv))]
        public int ArtigoPrivFK { get; set; }
        public Artigo_Privado ArtigoPriv { get; set; }

        [ForeignKey(nameof(ArtigoNAceite))]
        public int ArtigoNAceiteFK { get; set; }
        public Nao_Aceites ArtigoNAceite { get; set; }

        [ForeignKey(nameof(ArtigoPub))]
        public int ArtigoPubFK { get; set; }
        public Artigo_Publico ArtigoPub { get; set; }

        public ICollection<R2> R2 { get; set; }

        public ICollection<R3> R3 { get; set; }
    }
}
