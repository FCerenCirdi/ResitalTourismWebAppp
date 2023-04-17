using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
        public DateTime BookingDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }


        public int? HotelId { get; set; }
        public Hotel Hotel { get; set; }

        //public int CustomerId { get; set; }
        //public Customer Customer { get; set; }

        public int? ShipId { get; set; }
        public ShipTour ShipTour { get; set; }

        public int? TourId { get; set; }
        public Tour Tour { get; set; }
        public ICollection<CartLine> CartLines { get; set; }
    }
}
