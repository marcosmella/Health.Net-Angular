﻿using System.Collections.Generic;
using VL.Health.Domain.Entities;

namespace VL.Health.Interfaces.Repositories
{
	public interface IMedicalControlTrackingTypeRepository
	{
		List<MedicalControlTrackingType> Get();
		bool Exists(int id);
	}
}
