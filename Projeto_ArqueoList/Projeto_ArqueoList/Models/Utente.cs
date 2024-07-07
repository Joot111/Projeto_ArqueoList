using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Utente : Utilizador
    {
        public Utente() 
        {
        
        }

        public int idUtente { get; set; }

    }
}
