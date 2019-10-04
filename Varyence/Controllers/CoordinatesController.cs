using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Varyence.GeocodingServices;
using Varyence.GeocodingServices.ParseLocation;
using Varyence.Models.JsonModels;



namespace Varyence.Controllers
{
    [Route("api/[controller]")]
    public class CoordinatesController : BaseController
    {
        public CoordinatesController(IParseLocation geolocationService) : base(geolocationService)
        {

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> WeatherForecasts([FromQuery] string address)
        {
            
            var location = await GeolocationService.GetCoordinates(address);
            
            return new OkObjectResult(location);

        }
       
    }
}
