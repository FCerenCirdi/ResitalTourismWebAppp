using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Accommodation
    {
        [Key]
        public int AccommodationId { get; set; }
        public string Name { get; set; }
        public int RoomNumber { get; set; }
        public string Description { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }

        public int RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }

        public int RoomLocationId { get; set; }
        public RoomLocation RoomLocation { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public int ShipTourId { get; set; }
        public ShipTour ShipTour { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
