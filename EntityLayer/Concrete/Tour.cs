using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Region { get; set; }
        public string Image { get; set; }
        public string Capacity { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2 { get; set; }
        public string Image2 { get; set; }

        public int? CarCompanyId { get; set; }
        public CarCompany CarCompany { get; set; }

        public int GuideId { get; set; }
        public Guide Guide { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
