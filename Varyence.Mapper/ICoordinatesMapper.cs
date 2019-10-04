using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varyence.Models.CoordinatesModels;
using Varyence.Models.JsonModels;

namespace Varyence.Mapper
{
    public interface ICoordinatesMapper
    {
        Coordinates MapCoordinates(Location location);
    }
}
