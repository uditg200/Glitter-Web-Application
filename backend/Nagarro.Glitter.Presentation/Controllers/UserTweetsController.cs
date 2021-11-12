using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nagarro.Glitter.EntityDataModel.EntityModel;
namespace Nagarro.Glitter.Presentation.Controllers
{
    public class UserTweetsController : ApiController
    {
        public TweetDetails Post(TweetDetails tweetDetails)
        {
            return tweetDetails;
        }
    }
}
