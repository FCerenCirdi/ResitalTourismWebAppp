using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CheckedOutDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<CartLine> CartLines { get; set; }
       

    }
}
