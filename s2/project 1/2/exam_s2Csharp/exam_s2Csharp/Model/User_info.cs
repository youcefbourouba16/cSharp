using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_s2Csharp.Model
{
    public class User_info
    {
        private string username;
        private string password;

        

        public string Username {  get { return username; } set {  username = value; } }
        public string Password {  get { return password; } set {  password = value; } }

        public User_info(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User_info()
        {

        }
    }
}
