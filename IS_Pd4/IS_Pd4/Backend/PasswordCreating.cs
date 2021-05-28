using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_Pd4
{
    public class PasswordCreating
    {
        private string name;
        private string password;
        private string url;
        private string comment;

        public PasswordCreating(string name, string password, string url, string comment)
        {
            this.name = name;
            this.password = password;
            this.url = url;
            this.comment = comment;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public string GetUrl()
        {
            return this.url;
        }
        public string GetComment()
        {
            return this.comment;
        }
        public void Setname(string value)
        {
            this.name=value;
        }
        public void SetPassword(string value)
        {
            this.password = value;
        }
        public void SetUrl(string value)
        {
            this.url = value;
        }
        public void SetComment(string value)
        {
            this.comment = value;
        }
    }
}
