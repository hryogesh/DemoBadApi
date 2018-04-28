using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetApi.BusinessAccessLayer;

namespace TweetApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //TweetService serviceResult = new TweetService();
            //string URL = "https://badapi.iqvia.io/api/v1/Tweets";
            //var reslts = TweetService.GetTweetsAsync(URL);
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
