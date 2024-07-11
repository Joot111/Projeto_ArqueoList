using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Tag
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
    }
}
