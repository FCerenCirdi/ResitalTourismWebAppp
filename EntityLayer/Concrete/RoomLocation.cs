using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RoomLocation
    {
        [Key]
        public int RoomLocationId { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
        public ICollection<Accommodation> Accommodations { get; set; }
    }
}
