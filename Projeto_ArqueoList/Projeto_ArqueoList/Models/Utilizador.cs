using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Utilizador
    {
        [Key]
        public int idUtilizador { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateOnly Data_Nascimento { get; set; }
    }
}
