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
    public class TourManager : ITourService
    {
        ITourDal _tourDal;
        public TourManager(ITourDal tourDal)
        {
            _tourDal = tourDal;
        }

        public void TAdd(Tour t)
        {
            _tourDal.Insert(t);
        }

        public void TDelete(Tour t)
        {
           _tourDal.Delete(t);  
        }

        public Tour TGetByID(int id)
        {
            return _tourDal.GetById(id);
        }

        public List<Tour> TGetList()
        {
          return  _tourDal.GetList();
        }

        public void TUpdate(Tour t)
        {
            _tourDal.Update(t);
        }
    }
}