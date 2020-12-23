using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eRenting.Models
{
    public class CategoriaVeiculo
    {
        [Key]
        public int Categoria_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Categoria")]
        public string Nome { get; set; }
    }
}