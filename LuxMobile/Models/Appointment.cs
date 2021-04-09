using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace LuxMobile.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentNo { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Required.")]
        public DateTime Date { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Required.")]
        public DateTime Time { get; set; }

        [Display(Name = "Barber")]
        [Required(ErrorMessage = "Required.")]
        public virtual Barber Barber { get; set; } //foreign key to Barber model class

        [Display(Name = "Payment Method")]
        [Required(ErrorMessage = "Required.")]
        public string PaymentMethod { get; set; }

        [Required(ErrorMessage = "Required.")]
        public virtual Services Service { get; set; } //foreign key to Services model class

        [Required(ErrorMessage = "Required.")]
        public virtual BookingDetails BookingNo { get; set; } //foreign key to BookingDetails model class
    }
}
