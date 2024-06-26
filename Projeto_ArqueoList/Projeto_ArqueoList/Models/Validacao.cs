﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_ArqueoList.Models
{
    public class Validacao
    {
        [Key]
        public int ID_Validacao { get; set; }
        [StringLength(100)]
        public string Estado { get; set; }
        [StringLength(2000)]
        public string Motivo { get; set; }
        public DateOnly data_validacao { get; set; }

        [ForeignKey(nameof(ValidacaoArtigo))]
        public int ID_Artigo { get; set; }
        public Artigo ValidacaoArtigo { get; set; }


        [ForeignKey(nameof(AdminValidacao))]
        public int ID_Administrador { get; set; }
        public Administrador AdminValidacao { get; set; }
    }
}
