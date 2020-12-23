using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eRenting.Models
{
    public class Combustivel
    {
        [Key]
        public int Cumbustivel_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tipo de Combustível")]
        public string tipo_combustivel { get; set; }

    }
}