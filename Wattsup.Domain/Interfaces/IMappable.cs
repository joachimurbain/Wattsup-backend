using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wattsup.Domain.Models;

namespace Wattsup.Domain.Interfaces;
public interface IMappable<TEntity, TCreateDto, TUpdateDto, TDetailsDto, TListDto>
{
    TEntity ToEntity(TCreateDto dto);
    TEntity ToUpdatedEntity(TUpdateDto dto, TEntity existing);
    TDetailsDto ToDetailsDto(TEntity entity);
    TListDto ToListDto(TEntity entity);
}
