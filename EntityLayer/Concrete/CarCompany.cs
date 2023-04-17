using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarCompany
    {
        [Key]
        public int CarCompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Region { get; set; }
        public int AvailableCarId { get; set; }
        public ICollection<Tour> Tours { get; set; }
        public ICollection<Car> Cars { get; set; }
      
    }
}
