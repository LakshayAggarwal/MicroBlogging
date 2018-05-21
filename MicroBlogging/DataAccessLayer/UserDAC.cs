using System;
using System.Collections.Generic;
using System.Linq;
using ModelDTO;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserDAC
    {

        public Login Login(string email, string password)
        {
            Login returnedUserDTO = null;
            try
            {
                using (BlogContext context = new BlogContext())
                {
                    var userDetail = (from users in context.Users
                                      where users.Password == password &&
                                      users.EmailId == email
                                      select users).FirstOrDefault();


                    if (userDetail != null)
                    {
                        returnedUserDTO = new Login
                        {
                            EmailId = userDetail.EmailId,
                            Password = userDetail.Password,
                        };
                    }
                    else
                    {
                        returnedUserDTO = null;
                    }
                }
            }
            catch (NullReferenceException)
            {
                returnedUserDTO = null;
            }

            return returnedUserDTO;
        }

    }
}
