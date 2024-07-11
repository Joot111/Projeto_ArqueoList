using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Autor
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public string Biografia { get; set; }
    }
}
