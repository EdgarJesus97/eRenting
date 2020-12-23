using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace eRenting.Models
{
    public class Veiculo
    {
        [Key] 
        public int Veiculo_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Matricula")]
        public string Matricula { get; set; }

        [Required]
        [StringLength(250)]
        public string Marca { get; set; }

        [Required]
        [StringLength(250)]
        public string Modelo { get; set; }

        [Required]
        public int Cilindrada { get; set; }

        [Required]
        [Display(Name = "Kilometros")]
        public int Km { get; set; }

        [Required]
        [Display(Name = "Número do Motor")]
        public int Nmotor { get; set; }

        [Required]
        [StringLength(50)]
        public string Cor { get; set; }

        [Required]
        [Display(Name = "Número de Portas")]
        public int Nportas { get; set; }

        [Required]
        [Display(Name = "Ano de Fabrico")]
        public int Ano_Fabrico { get; set; }

        [Required]
        [Display(Name = "Lotação")]
        public int Locatacao { get; set; }

        [Required]
        [Display(Name = "Observações Especiais")]
        [StringLength(250)]
        public string Observacoes { get; set; }

        [Required]
        [Display(Name = "Preço Dia")]
        public float preco_dia { get; set; }

        public Combustivel Combustivel { get; set; }

        [ForeignKey("Combustivel")]
        public int Combustivel_id { get; set; }

        public CategoriaVeiculo CategoriaVeiculo { get; set; }

        [ForeignKey("CategoriaVeiculo")]
        public int CategoriaVeiculo_id { get; set; }
        
        public Status Status { get; set; }

        [ForeignKey("Status")]
        public int Status_id { get; set; }

        public Empresa Empresa { get; set; }

        [ForeignKey("Empresa")]
        public int Empresa_id { get; set; }
    }
}