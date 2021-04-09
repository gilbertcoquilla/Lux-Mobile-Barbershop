using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace LuxMobile.Models
{
    public class Barber
    {
        [Key]
        public int BarberNo { get; set; }

        [Required(ErrorMessage = "Required.")]
        public string BarberName { get; set; }
    }
}
