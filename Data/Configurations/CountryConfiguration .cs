using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelListingAPI.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Ukraine",
                        ShortName = "UA",
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Czech Republic",
                        ShortName = "CZ",
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "USA",
                        ShortName = "US",
                    }
                );
        }
    }
}
