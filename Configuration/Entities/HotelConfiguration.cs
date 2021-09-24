using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configuration.Entities
{
    public class HotelConfiguration:IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Sheraton",
                   Address = "30, Mobolaji Bank Anthony Way, Airport Road, Ikeja GRA",
                   Rating = 4.50,
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
