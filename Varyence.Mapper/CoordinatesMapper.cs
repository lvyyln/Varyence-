using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varyence.Models.CoordinatesModels;
using Varyence.Models.JsonModels;

namespace Varyence.Mapper
{
    public class CoordinatesMapper : ICoordinatesMapper
    {
        public Coordinates MapCoordinates(Location location) 
        {
            var coordinates = new Coordinates();
            coordinates.Latitude = location.Lat;
            coordinates.Longitude = location.Lng;
            
            return coordinates;
        }
    }
}
