﻿using System.Collections.Generic;
using VL.Health.Domain.Entities;

namespace VL.Health.Interfaces.Repositories
{
    public interface IAccidentReopeningRepository
    {
        List<AccidentReopening> Get();
    }
}
