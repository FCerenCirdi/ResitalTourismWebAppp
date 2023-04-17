using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ShipTour
    {
        [Key]
        public int ShipId { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string DayNight { get; set; }
        public string Image { get; set; }
        public string Capacity { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public ICollection<Accommodation> Accommodations { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
