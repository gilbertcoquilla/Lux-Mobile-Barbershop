using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace LuxMobile.Models
{
    public class BookingDetails
    {
        [Key]
        public int BookingNo { get; set; }

        [Required(ErrorMessage = "Required.")]
        public int ServicesAvailed { get; set; }

        [Required(ErrorMessage = "Required.")]
        public decimal TotalPrice { get; set; }

    }
}
