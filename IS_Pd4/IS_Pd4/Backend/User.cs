using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Pd4
{
    public class User
    {
        private static string username;
        private static string password;
        public List<PasswordCreating> info;
        public User()
        {
            info = new List<PasswordCreating>();
        }

        public void SetUsername(string value)
        {
            username = value;
        }
        public void SetPassword(string value)
        {
            password = value;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
