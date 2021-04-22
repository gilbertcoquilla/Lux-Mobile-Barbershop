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

        [Display(Name = "Date and Time")]
        [Required(ErrorMessage = "Required.")]
        public DateTime? BookingDate { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Payment Method")]
        [Required(ErrorMessage = "Required.")]
        public string PaymentMethod { get; set; }

        [Display(Name = "Account Number")]
        [DataType(DataType.CreditCard)]
        public string AccountNumber { get; set; }

        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Barber")]
        public string BarberName { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name = "Service:")]
        public string Service { get; set; }

        [Display(Name = "Total Price")]
        public string TotalPrice { get; set; }
    }
}
