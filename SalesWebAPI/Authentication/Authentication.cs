using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SalesWebAPI
{
    /// <summary>
    /// Class to authenticate a user
    /// </summary>
    public class Authentication
    {
        const String TestUsername = "Restaurant";
        const String TestPassword = "123456";
        /// <summary>
        /// Validates a user's credentials
        /// </summary>
        /// <param name="username">User's Username</param>
        /// <param name="password">User's Password</param>
        /// <returns>boolean indicating whether a user is valid</returns>
        public static bool VaidateUser(string username, string password)
        {
            bool bReturn = false;
            if (String.Equals(TestUsername, username) && String.Equals(TestPassword, password))
            {
                bReturn = true;
            }
            else
            {
                bReturn = false;
            }
            return bReturn;
        }
    }
}