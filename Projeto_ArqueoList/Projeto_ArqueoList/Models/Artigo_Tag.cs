using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class ArtigoTag
    {
        [ForeignKey("Artigo")]
        public int ArtigoID { get; set; }
        public Artigo Artigo { get; set; }

        [ForeignKey("Tag")]
        public int TagID { get; set; }
        public Tag Tag { get; set; }
    }
}
