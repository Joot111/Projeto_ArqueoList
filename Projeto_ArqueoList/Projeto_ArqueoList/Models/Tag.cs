using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Tag
    {
        [Key]
        public int ID_Tag { get; set; }
        [StringLength(50)]
        public int Nome { get; set; }
    }
}
