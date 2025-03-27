﻿using Wattsup.BLL.Services.Base.Interfaces;

namespace Wattsup.Api.Controllers.Base;

public abstract class BaseEntityController<TEntity>
	: BaseDtoController<TEntity, TEntity, TEntity, TEntity, TEntity, TEntity>
	where TEntity : class
{
	protected BaseEntityController(IBaseService<TEntity> service) : base(service) { }

	protected override TEntity ToEntity(TEntity dto) => dto;
	protected override TEntity ToUpdateEntity(TEntity dto) => dto;
	protected override TEntity ToDetailsDto(TEntity entity) => entity;
	protected override TEntity ToListDto(TEntity entity) => entity;
}