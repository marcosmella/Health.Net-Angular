using System.Collections.Generic;
using VL.Health.Domain.Entities;

namespace VL.Health.Interfaces.Managers
{
    public interface IAccidentStatusManager
    {
        List<AccidentStatus> Get();
    }
}
