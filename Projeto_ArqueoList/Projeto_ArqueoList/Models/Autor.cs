using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Autor : Utilizador
    {
        [ForeignKey(nameof(ArtigoPub))]
        public string ArtigoPubFK { get; set; }
        public Artigo ArtigoPub { get; set; }
    }
}
