using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eRenting.Models
{
    public class StatusReserva
    {
        [Key]
        public int StatusReserva_id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Estado da Reserva")]
        public string Estado_reserva { get; set; }
    }
}