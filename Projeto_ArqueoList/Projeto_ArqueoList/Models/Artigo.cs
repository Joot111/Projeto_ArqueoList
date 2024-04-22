using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Artigo
    {
        public Artigo() {
            ListaAutores = new HashSet<Autor>();
        }
        [Key]
        public int ID { get; set; }
        public int ID_Utente { get; set; }  
        public int ID_Admnistrador { get; set; }
        public int ID_Autor { get; set; }
        [StringLength(70)]
        public string Titulo { get; set; }
        [StringLength(5000)]
        public string Conteudo { get; set; }
        public string Imagem { get; set; }   
        [StringLength(50)]
        public string Nome_Autor { get; set; }
        public Boolean validado { get; set; }
        public DateOnly data_validacao { get; set; }
        [StringLength(50)]
        public string tipo {  get; set; }



        [ForeignKey(nameof(ArtigoEsp))]
        public int ArtigoEspFK { get; set; }
        public Artigo_Em_Espera ArtigoEsp { get; set; }

        public ICollection<Autor> ListaAutores { get; set; }
    }

}
