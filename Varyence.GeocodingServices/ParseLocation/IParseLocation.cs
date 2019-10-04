using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varyence.Models.CoordinatesModels;

namespace Varyence.GeocodingServices.ParseLocation
{
    public interface IParseLocation 
    {
        Task<Coordinates> GetCoordinates(string address);
    }
}
