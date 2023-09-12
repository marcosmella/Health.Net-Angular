﻿using System.Collections.Generic;
using VL.Health.Domain.Entities;

namespace VL.Health.Interfaces.Managers
{
    public interface IMedicalControlTypeManager
    {
        List<MedicalControlType> Get();
    }
}