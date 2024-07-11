using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Utente
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
    }
}
