using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Security.Policy;

namespace ResitalTourismWebApp.Views.ViewModels
{
    public class TourViewModel
    {
        public List<Tour> Tours { get; set; }
        public List<ShipTour> ShipTours { get; set; }
        public List<Hotel> Hotels { get; set; }
        public int TourId { get; set; }
        public int ShipId { get; set; }
        public int HotelId { get; set; }
     
        public string HotelName { get; set; }
        public string HotelDayNight { get; set; }
        public string HotelAddress { get; set; }
        public int HotelPrice { get; set; }
        public bool HotelStatus { get; set; }

        public string TourName { get; set; }
        public string Description { get; set; }
        public int TourCapacity { get; set; }
        public int TourPrice { get; set; }
        public string Detail1 { get; set; }
        public string Detail2 { get; set; }
        public int GuideId { get; set; }

        public string ShipName { get; set; }
        public string Region { get; set; }
        public string ShipTourDayNight { get; set; }
        public int ShipTourCapacity { get; set; }
        public int ShipTourPrice { get; set; }
        public bool ShipTourStatus { get; set; }


        // boş liste nesneleri 
        public TourViewModel()
        {
            Tours = new List<Tour>();
            ShipTours = new List<ShipTour>();
            Hotels = new List<Hotel>();
        }
    }

}
