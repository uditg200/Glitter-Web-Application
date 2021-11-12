using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.Glitter.EntityDataModel.EntityModel;
using Nagarro.Glitter.Data.DataAccessComponent;

namespace Nagarro.Glitter.Business.Business
{
    public class UserBdc
    {
        private readonly UserDac userDac = new UserDac();
        public void AddUser(UserDetails userDetails)
        {
            userDac.AddUserDetails(userDetails);
        }
        public IEnumerable<UserDetails> GetAllUsers()
        {
            return userDac.GetAllUsers();
        }
    }
}
