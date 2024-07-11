using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Validacao : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime data = Convert.ToDateTime(value);
                if (data >= DateTime.Now)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("A data de validação não pode ser no passado.");
                }
            }
            return new ValidationResult("A data de validação é obrigatória.");
        }
    }
}
