using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HootHootLibrary
{
    class User
    {
        public string username { get; set; }
        private string password { get; set; }
        public string usertype { get; set; }

        public User (string un, string pw, string ut)
        {
            username = un;
            password = pw;
            usertype = ut;
        }
    }
}
