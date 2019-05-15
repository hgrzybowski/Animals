using System.Collections.Generic;

namespace Animals.Models.ViewModel
{
    public class AppointmentDetailsViewModel
    {

        public Appointments Appointment { get; set; }
        public List<ApplicationUser> SalesPerson { get; set; }
        public List<Products> Products { get; set; }

    }
}
