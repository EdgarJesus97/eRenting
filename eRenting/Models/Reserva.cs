using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace eRenting.Models
{
    public class Reserva
    {
        [Key]
        public int Reserva_id { get; set; }
        
        [Display(Name = "Data de Inicio")]
        [DisplayFormat(ApplyFormatInEditMode =  true, DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime data_inicio { get; set; }

        [Display(Name = "Data de Fim")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm}")]
        public DateTime data_fim { get; set; }


        public Cliente Cliente { get; set; }

        [ForeignKey("Cliente")]
        public int Cliente_id { get; set; }

        public Veiculo Veiculo { get; set; }

        [ForeignKey("Veiculo")]
        public int Veiculo_id { get; set; }

        public StatusReserva StatusReserva { get; set; }

        [ForeignKey("StatusReserva")]
        public int StatusReserva_id { get; set; }

    }
}