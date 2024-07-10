using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    //validação dos espaços preenchidos
    public class Validacao
    {
        [Key]
        public int ID_Validacao { get; set; }

        [StringLength(100)]
        public string Estado { get; set; }

        [StringLength(2000)]
        public string Motivo { get; set; }

        [CustomDate(ErrorMessage = "A data de validação não pode ser no futuro.")]
        public DateTime data_validacao { get; set; }

        [ForeignKey(nameof(ValidacaoArtigo))]
        public int ID_Artigo { get; set; }
        public Artigo ValidacaoArtigo { get; set; }

        [ForeignKey(nameof(AdminValidacao))]
        public int ID_Administrador { get; set; }
        public Administrador AdminValidacao { get; set; }
    }

    //validação da data de nascimento e do artigo
    public class CustomDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime data = Convert.ToDateTime(value);
                if (data > DateTime.Now)
                {
                    return new ValidationResult("A data não pode ser no futuro.");
                }
            }
            return ValidationResult.Success;
        }
    }
}
