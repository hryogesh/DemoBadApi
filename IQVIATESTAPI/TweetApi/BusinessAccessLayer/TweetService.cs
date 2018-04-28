using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using TweetApi.Models;

namespace TweetApi.BusinessAccessLayer
{
    public class TweetService
    {
        private const string URL = "https://badapi.iqvia.io/api/v1/Tweets";

       public static  List<Tweets> GetTweetsAsync(string URL, DateTime startDate,DateTime endDate)
        {
            string urlParameters = "?startDate="+ startDate.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'") +"&endDate="+ endDate.ToUniversalTime()
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");

            //string urlParameters1="?startDate=2015-03-20T04:07:56.271Z&endDate=2015-05-20T04:07:56.271Z";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Clear();
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                // List data response.
                HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
                List<Tweets> tweetsResults = new List<Tweets>();
                if (response.IsSuccessStatusCode)
                {
                    // Parse the response body. Blocking!
                    //tweetsResults = response.Content.ReadAsAsync<IEnumerable<Tweets>>().Result.Distinct().ToList<Tweets>();
                    tweetsResults = response.Content.ReadAsAsync<IEnumerable<Tweets>>().Result.Distinct().ToList<Tweets>();
                }
                return tweetsResults;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}