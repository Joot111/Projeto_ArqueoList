using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Administrador
    {
        [Key]
        public int idAdmin { get; set; }
        [StringLength(30)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateOnly Data_Nascimento { get; set; }

        [ForeignKey(nameof(Artigo))]
        public int Artigo_FK { get; set; }
        public Artigo Artigo { get; set; }
    }
}
