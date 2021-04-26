using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HootHootLibrary
{
    public class User
    {
        private string username;
        private string password;
        private string usertype;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public String Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }
    }
}
