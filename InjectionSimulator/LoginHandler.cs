using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InjectionInloggning
{
    public class LoginHandler
    {
        Dictionary<string, string> validLoginCredentials = new Dictionary<string, string> 
        { 
            { "Olle", "Yo123" },
            { "Jonas", "JoNas" }
        };

        string userName;
        string password;
        Regex controller = new Regex("^[a-zA-Z0-9]+$");

        public LoginHandler(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public bool CheckLoginStatus()
        {
            foreach (KeyValuePair<string, string> kvp in validLoginCredentials)
            {
                if (this.userName == kvp.Key && this.password == kvp.Value)
                {
                    return true;
                }
            }
            return false;
        }

        public string Login()
        {
            if (!controller.IsMatch(this.password))
            {
                MessageBox.Show("Password contains unallowed characters.", "Unallowed characters in string", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (!controller.IsMatch(this.userName))
            {
                MessageBox.Show("Username contains unallowed characters.", "Unallowed characters in string", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (CheckLoginStatus())
            {
                return "Du är inloggad";
            }
            return "Du är utloggad";
        }
    }
}
