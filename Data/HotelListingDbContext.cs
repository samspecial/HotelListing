using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Germany",
                    ShortName = "DE"
                },
                new Country
                { 
                    Id = 2, 
                    Name = "Bulgaria", 
                    ShortName = "BG" 
                },
                new Country
                {
                    Id=3,
                    Name="Denmark",
                    ShortName="DK"
                },
                new Country
                {
                    Id=4,
                    Name="Czechia",
                    ShortName="CZ"
                },
                new Country
                {
                    Id=5,
                    Name="Belgium",
                    ShortName="BE"
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name="Sheraton",
                    Address="30, Mobolaji Bank Anthony Way, Airport Road, Ikeja GRA",
                    Rating=4.50,
                    CountryId = 2,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Wheatbaker",
                    Address = "4, Onitolo Road, Off Gerrard Road",
                    Rating = 3.70,
                    CountryId = 1,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Transcorp Hilton",
                    Address = "30, Mobolaji Bank Anthony Way, Airport Road, Ikeja GRA",
                    Rating = 4.65,
                    CountryId = 5,
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Hotel Presidential",
                    Address = "5141, Aba Road, GRA Phase 2, Rumuadaolu",
                    Rating = 4.10,
                    CountryId = 2,
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Golden Royale",
                    Address = "10, Bisala Road, Independence Layout",
                    Rating = 3.50,
                    CountryId = 3,
                }
                );
        }
       
    }
}
