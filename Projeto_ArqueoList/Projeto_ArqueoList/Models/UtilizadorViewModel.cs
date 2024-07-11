using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class UtilizadorViewModel
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
