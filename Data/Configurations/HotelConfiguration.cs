using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListingAPI.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {

            builder.HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "Mriya",
                        Address = "Kharkiv",
                        CountryId = 1,
                        Rating = 5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "New Castle",
                        Address = "Nove Hrady",
                        CountryId = 2,
                        Rating = 4.4
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Dream",
                        Address = "New York City",
                        CountryId = 3,
                        Rating = 4.5
                    }
                );
        }
    }
}
