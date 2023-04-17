﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public List<Booking> GetListWithBookingByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Bookings.Include(x => x.Tour).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();
            }
        }

        public List<Booking> GetListWithBookingByApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Bookings.Include(x => x.Tour).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList();
            }
        }

        public List<Booking> GetListWithBookingByPass(int id)
        {
            using (var context = new Context())
            {
                return context.Bookings.Include(x => x.Tour).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            }
        }
    }
}
