using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Varyence.GeocodingServices.ParseLocation;

namespace Varyence.Controllers
{
    
    [Produces("application/json")]
    public class BaseController : Controller
    {
       protected IParseLocation GeolocationService { get; }
       public BaseController(IParseLocation geolocationService)
       {
            GeolocationService = geolocationService;
       }
    }

}
