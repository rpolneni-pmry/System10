using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System10
{
    public static class Utility
    {
        public static string GetUserNameFromEmail(string email,bool isDomain=false)
        {
            String username = email;
            if (email.Contains("@"))
            {
                String[] userData = email.Split(new[] { '@' });
                 username = userData[0];
                if(isDomain)
                {
                    return userData[1];
                }
                return username;
            }
            else
            {
                if(email.Contains("\\"))
                {
                    String[] userData = email.Split(new[] { '\\' });
                    username = userData[1];
                }
                
               
                return username;
            }
            
        }
       
    }
}
