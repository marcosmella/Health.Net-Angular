﻿using System.Collections.Generic;
using VL.Health.Domain.Entities;

namespace VL.Health.Interfaces.Managers
{
    public interface IVaccineManager
    {
		List<Vaccine> Get();
    }
}
