using DataAccessLayer;
using ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserBusinessLogic
    {
        UserDAC userDAC = new UserDAC();

        public Login Login(string email, string password)
        {
            var userDetails = userDAC.Login(email, password);
            return userDetails;
        }

    }
}
