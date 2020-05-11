using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using ShoppingCartApp.Models;

namespace ShoppingCartApp
{
    public class ApiProcessor
    { 
      
    
        public static async Task<HolidayModel> LoadHoliday(string userCountry, int userYear)
        {

            IRestClient restClient = new RestClient();  
            IRestRequest restRequest = new RestRequest("https://calendarific.com/api/v2/holidays?api_key=83e943dbd01aa32c61f09e337f3ddca107a12c38&country={country}&year={year}", Method.GET, DataFormat.Json);
            restRequest.AddParameter("country", userCountry, ParameterType.UrlSegment);
            restRequest.AddParameter("year", userYear, ParameterType.UrlSegment);
            

            
            IRestResponse<HolidayModel> restResponse = await restClient.ExecuteAsync<HolidayModel>(restRequest);

            return restResponse.Data;

            

           
        }
        //public static async Task<HolidayModel> LoadHoliday(string userCountry, int userYear)
        //{

        //    var client = new IRestClient("https://calendarific.com/api/v2/");
        //    var request = new RestRequest($"holidays?api_key=83e943dbd01aa32c61f09e337f3ddca107a12c38&country={userCountry}&year={userYear}", Method.GET);
      
        //    var queryResult = await client.ExecuteAsync<HolidayModel>(request);
        //    HolidayModel holiday = queryResult.Data;
        //    return holiday;
        //}
    }
}
