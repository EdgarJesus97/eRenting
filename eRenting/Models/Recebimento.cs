using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace eRenting.Models
{
    public class Recebimento
    {
        [Key]
        public int Recebimento_id { get; set; }

        [StringLength(250)]
        public string Defeitos { get; set; }

        [Required]
        [Display(Name = "Kilometros Finais")]
        public int Km_finais { get; set; }

        [Required]
        [Display(Name = "Nível Depósito Final")]
        public int Nivel_deposito { get; set; }

        public Funcionario Funcionario { get; set; }

        [ForeignKey("Funcionario")]
        public int Funcionario_id { get; set; }
    }
}