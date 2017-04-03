using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;



namespace Elective_1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string getLocation(string term, string zipcode)
        {
            YelpAPIClient client = new YelpAPIClient();
            var result = client.Search(term , zipcode);
            string s = "";
            if (result.Businesses.Length > 0)
            {
                for (int i = 0; i < result.Businesses.Length; i++)
                {
                   s = s + " { Restaurant Name: " + result.Businesses[i].Name + " / Phone Number:" +result.Businesses[i].DisplayPhone +" / Address "+ result.Businesses[i].Location.DisplayAddress[0]+" }";
                }
                //var yelpResult = y.SearchYelpInfo(rPlace.restaurantName, rPlace.restaurantCity);
                return s;
            }
            return "No Results found for this search";
        }
    }
}
