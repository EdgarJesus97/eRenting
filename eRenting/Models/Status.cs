using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eRenting.Models
{
    public class Status
    {
        [Key]
        public int Estado_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }
    }
}