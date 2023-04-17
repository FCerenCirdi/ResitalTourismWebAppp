using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string DayNight { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

        public ICollection<Accommodation> Accommodations { get; set; }
    }
}
