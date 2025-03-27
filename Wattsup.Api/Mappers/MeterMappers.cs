using Wattsup.Api.DTOs.MeterDTOs;
using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Mappers;

public static class MeterMappers
{
    public static DetailsMeterDTO ToDetailsDto(this Meter entity)
    {
        return new DetailsMeterDTO
        {
            Id = entity.Id,
            DeactivationDate = entity.DeactivationDate,
            QrCode = entity.QrCode,
            StoreId = entity.Store.Id
        };
    }
}
