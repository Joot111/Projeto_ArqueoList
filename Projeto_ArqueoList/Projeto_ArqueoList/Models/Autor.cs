using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Autor : Utilizador
    {
        public Autor() {
            
        }

        public int idAutor { get; set; }

        
    }
}
