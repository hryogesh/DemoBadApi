using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TweetApi.Models
{
    public class Tweets
    {
        public string Id { get; set; }
        public DateTime Stamp { get; set; }
        public string Text { get; set; }
    }
}