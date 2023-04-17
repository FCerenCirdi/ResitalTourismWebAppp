using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-CQCUVNS\\SQLEXPRESS;database=ResitalDb; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars  { get; set; }
        public DbSet<CarCompany> CarCompanies  { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Guide> Guides  { get; set; }
        public DbSet<Hotel> Hotels  { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes  { get; set; }
        public DbSet<RoomLocation> RoomLocations  { get; set; }
        public DbSet<ShipTour> ShipTours  { get; set; }
        public DbSet<Tour> Tours  { get; set; }
        public DbSet<AppUser> AppUsers   { get; set; }
        public DbSet<AppRole> AppRoles   { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }
        public DbSet<Comment> Comments  { get; set; }

    }
}
