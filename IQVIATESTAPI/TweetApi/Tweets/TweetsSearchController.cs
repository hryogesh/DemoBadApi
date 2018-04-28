using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TweetApi.BusinessAccessLayer;
using TweetApi.Models;


namespace TweetApi.TweetsSearch
{
    public class TweetsSearchController : ApiController
    {
       
        public List<TweetApi.Models.Tweets> GetTweets(DateTime startDate,DateTime endDate)
        {
            string URL = "https://badapi.iqvia.io/api/v1/Tweets";
            TweetService serviceResult = new TweetService();

            var reslts = TweetService.GetTweetsAsync(URL, startDate,endDate);
            return reslts;
        }

    }      
       
       
}
