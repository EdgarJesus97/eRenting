using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eRenting.Models
{
    public class Empresa
    {
        [Key]
        public int Empresa_id { get; set; }

        [Required]
        [StringLength(120)]
        public string Nome { get; set; }

        [Required]
        public string Morada { get; set; }

        [Required]
        public int Nif { get; set; }

        [Required]
        public int Cod_postal_cidade { get; set; }

        [Required]
        public int Cod_postal_rua { get; set; }

        [Required]
        public string Localidade { get; set; }

        [Required]
        [RegularExpression("([0-9]{9})", ErrorMessage = "O número de telefone não é válido!")]
        public int Contacto { get; set; }

        public int Fax { get; set; }

        [StringLength(120)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}