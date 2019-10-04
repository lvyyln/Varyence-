using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Varyence.Models.CoordinatesModels;
using Varyence.Models.JsonModels;
using Varyence.Mapper;
using Varyence.GeocodingServices.GeocodingService;

namespace Varyence.GeocodingServices.ParseLocation
{
    public class ParseLocation : IParseLocation
    {
        private readonly ICoordinatesMapper _coordinatesMapper;
        private readonly IGeocodingService _geocodingService;
        
        public ParseLocation(IGeocodingService geocodingService,ICoordinatesMapper coordinatesMapper)
        {
            _geocodingService = geocodingService;
            _coordinatesMapper = coordinatesMapper;
        }
      
        public async Task<Coordinates> GetCoordinates(string address)
        {
            var geocode = await _geocodingService.GetGCode(address);

            var location = geocode.Results.First(result => result.Geometry.Location != null).Geometry.Location;

            return _coordinatesMapper.MapCoordinates(location);
        }
    }
}
