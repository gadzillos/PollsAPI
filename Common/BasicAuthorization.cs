using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollsAPI.Common
{
    public static class BasicAuthorization
    {
        public static bool CheckHeader(string header)
        {
            if (!(header != null && header.StartsWith("Basic")))
            {
                return false;
            }

            return true;
        }

        public static (string username, string password) GetCredentials(string header)
        {
            // Exctract
            string encodedUsernamePassword = header.Substring("Basic ".Length).Trim();

            // Decode
            Encoding encoding = Encoding.GetEncoding("UTF-8");
            string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedUsernamePassword));

            // Split
            int separatorIndex = usernamePassword.IndexOf(':');

            string username = usernamePassword.Substring(0, separatorIndex);
            string password = usernamePassword.Substring(separatorIndex + 1);

            return (username: username, password: password);
        }

        public static bool IsOrganizator(string password)
        {
            if (password.EndsWith("!"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
