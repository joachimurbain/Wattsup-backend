﻿using Wattsup.Domain.CustomEnums;

namespace Wattsup.Api.DTOs.MeterDTOs;

public class DetailsMeterDTO
{

	public int Id { get; set; }
	public Guid Uuid { get; set; }
	public MeterType Type { get; set; }
	public DateTime? DeactivationDate { get; set; }
	public string QrCode { get; set; }
	public int StoreId { get; set; }
	public DateTime LastReading { get; set; }
	//public List<MeterReading> Readings { get; set; } = [];

}
