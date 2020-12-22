using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eRenting.Models
{
    public class Funcionario
    {
        [Key]
        public int Funcionario_id { get; set; }

        [Required]
        [StringLength(120)]
        public string Nome { get; set; }

        [Required]
        public int Contacto { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Empresa Empresa { get; set; }
    }
}