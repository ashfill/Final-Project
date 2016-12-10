using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
namespace FinalProject3.Models
{
    public class Ebay
    {
        public object GetCurrentWeather()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Detroit&APPID=429722d39c5146cca3562374e86f4bbe&units=imperial";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);

            return jsonContent;
        }
    }
}