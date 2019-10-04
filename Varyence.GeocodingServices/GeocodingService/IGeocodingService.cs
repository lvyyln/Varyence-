using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varyence.Models.JsonModels;

namespace Varyence.GeocodingServices.GeocodingService
{
    public interface IGeocodingService
    {
        Task<GeocodeAnswer> GetGCode(string adress);
    }
}
