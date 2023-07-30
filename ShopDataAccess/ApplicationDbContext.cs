using Microsoft.EntityFrameworkCore;
using ShopDataModel.Model;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ShopDataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PhoneList> PhoneLists { get; set; }
        public DbSet<PhoneBooking> PhoneBookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneList>().HasData(
                new PhoneList
                {
                    Id = Guid.NewGuid(),
                    PhoneModel = "IPhone114pro",
                    PhonePrice = 1000
                }
            );
            modelBuilder.Entity<PhoneList>().HasData(
                new PhoneList
                {
                    Id = Guid.NewGuid(),
                    PhoneModel = "SmasungGalaxys11",
                    PhonePrice = 1500
                }
            );
            modelBuilder.Entity<PhoneList>().HasData(
                new PhoneList
                {
                    Id = Guid.NewGuid(),
                    PhoneModel = "RedmiNote12pro",
                    PhonePrice = 400
                }
            );
            modelBuilder.Entity<PhoneList>().HasData(
              new PhoneList
              {
                  Id = Guid.NewGuid(),
                  PhoneModel = "Iphone13promax",
                  PhonePrice = 1300
              }
          );
        }
    }
}