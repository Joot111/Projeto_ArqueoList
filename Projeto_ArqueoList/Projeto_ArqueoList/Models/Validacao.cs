using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Validacao
    {
        [Key]
        public int ID_Validacao { get; set; }
        public int ID_Artigo { get; set; }
        public int ID_Administrador { get; set; }
        [StringLength(100)]
        public string Estado { get; set; }
        [StringLength(2000)]
        public string Motivo { get; set; }
        public DateOnly data_validacao { get; set; }
    }
}
