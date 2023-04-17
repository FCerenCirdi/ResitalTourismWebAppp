using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class ShipTourManager : IShipTourService
    {
        IShipTourDal _shipTourDal;
        public ShipTourManager(IShipTourDal shipTourDal)
        {
            _shipTourDal = shipTourDal;
        }

        public void TAdd(ShipTour t)
        {
            _shipTourDal.Insert(t);
        }

        public void TDelete(ShipTour t)
        {
            _shipTourDal.Delete(t);
        }

        public ShipTour TGetByID(int id)
        {
            return _shipTourDal.GetById(id);
        }

        public List<ShipTour> TGetList()
        {
            return _shipTourDal.GetList();
        }

        public void TUpdate(ShipTour t)
        {
            _shipTourDal.Update(t);
        }
    }
}
