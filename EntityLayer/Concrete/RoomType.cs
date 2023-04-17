using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public ICollection<Accommodation> Accommodations { get; set; }
    }
}
