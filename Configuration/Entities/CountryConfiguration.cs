using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configuration.Entities
{
    public class CountryConfiguration:IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
                              Id = 3,
                              Name = "Denmark",
                              ShortName = "DK"
                          },
                          new Country
                          {
                              Id = 4,
                              Name = "Czechia",
                              ShortName = "CZ"
                          },
                          new Country
                          {
                              Id = 5,
                              Name = "Belgium",
                              ShortName = "BE"
                          }
                          );
        }
    }
}
