using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nagarro.Glitter.EntityDataModel.EntityModel;

namespace Nagarro.Glitter.Data.DataAccessComponent
{
    public class UserDac
    {
        private readonly GlitterContext dB = new GlitterContext();
        public void AddUserDetails(UserDetails user)
        {
            dB.AllUsers.Add(user);
            dB.SaveChanges();
        }
        public IEnumerable<UserDetails> GetAllUsers()
        {
            IEnumerable<UserDetails> allUsers = dB.AllUsers;
            return allUsers;
        }
    }
}
