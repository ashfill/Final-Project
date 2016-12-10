using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace CarProject.Models
{
    public class Ebays
    {
        public object GetSearch()
        {
            string url = "http://svcs.ebay.com/services/search/FindingService/v1?OPERATION-NAME=findItemsByKeywords&SERVICE-VERSION=1.0.0&SECURITY-APPNAME=AshtonFi-Cars-PRD-b45ed6035-235294a3&RESPONSE-DATA-FORMAT=XML&REST-PAYLOAD&keywords=harry%20potter%20phoenix";
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<object>(content);

            return jsonContent;
        }
    }
}