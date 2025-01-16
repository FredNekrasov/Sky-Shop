using SkyShop.DAL.Database.Entities;
using SkyShop.DAL.FakeRemote.DTOs;

namespace SkyShop.DAL.Mappers;

public static class TicketMapper
{
    public static Ticket ToModel(this TicketDTO dto, int id, IFormatProvider formatProvider) => new()
    {
        Id = id,
        StartCity = dto.StartCity,
        StartCityCode = dto.StartCityCode,
        EndCity = dto.EndCity,
        EndCityCode = dto.EndCityCode,
        StartDate = DateTime.Parse(dto.StartDate, formatProvider),
        EndDate = DateTime.Parse(dto.EndDate, formatProvider),
        Price = dto.Price
    };
}
