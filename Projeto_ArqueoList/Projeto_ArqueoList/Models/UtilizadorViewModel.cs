using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class UtilizadorViewModel
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data_Nascimento { get; set; }
    }
}
