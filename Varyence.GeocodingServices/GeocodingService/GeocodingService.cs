using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Varyence.Models.JsonModels;

namespace Varyence.GeocodingServices.GeocodingService
{
    public class GeocodingService : IGeocodingService
    {
        private string _geocodeadress = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key=AIzaSyDhoFmKesQQoiXetSGFXg8RDwIRVPa7ur0";
        
        public async Task<GeocodeAnswer> GetGCode(string adress)
        {
            var url = String.Format(_geocodeadress, adress);
           
            using (var client = new HttpClient())
            {
                var jsonanswer = await client.GetStringAsync(url);
                var result = JsonConvert.DeserializeObject<GeocodeAnswer>(jsonanswer);             
                return result;
            }
            
        }
    }
}
