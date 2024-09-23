using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
