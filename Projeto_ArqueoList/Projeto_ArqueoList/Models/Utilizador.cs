using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_ArqueoList.Models
{
    public class Utilizador
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; }
    }
}
