using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
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
            modelBuilder.Entity<Hotel>().HasData(
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
