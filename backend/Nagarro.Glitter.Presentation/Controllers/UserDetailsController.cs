using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nagarro.Glitter.EntityDataModel.EntityModel;
using Nagarro.Glitter.Business.Business;

namespace Nagarro.Glitter.Presentation.Controllers
{
    public class UserDetailsController : ApiController
    {
        public UserDetails Post(UserDetails userDetails) {
            UserBdc user = new UserBdc();
            user.AddUser(userDetails);
            return userDetails;
        }
        public IEnumerable<UserDetails> Get()
        {
            UserBdc user = new UserBdc();
            return user.GetAllUsers();
        }
    }
}
