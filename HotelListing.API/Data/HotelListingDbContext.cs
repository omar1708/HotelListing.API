using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
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
                        Name = "Jamaica",
                        ShortName = "BS"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Bahamas",
                        ShortName = "BS"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Cayman Island",
                        ShortName = "CI"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "Peru",
                        ShortName = "PE"
                    }
                );
            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel
                    {
                        Id = 1,
                        Name = "Sheraton",
                        Address = "Negril",
                        CountryId = 1,
                        Rating = 4.5
                    },
                    new Hotel
                    {
                        Id = 2,
                        Name = "Todos Vuelven",
                        Address = "George Town",
                        CountryId = 2,
                        Rating = 2
                    },
                    new Hotel
                    {
                        Id = 3,
                        Name = "Oasis",
                        Address = "Lima",
                        CountryId = 3,
                        Rating = 4.6
                    },
                    new Hotel
                    {
                        Id = 4,
                        Name = "Estrellas",
                        Address = "Pacasmayo",
                        CountryId = 4,
                        Rating = 3
                    }
                );
        }
    }
}
