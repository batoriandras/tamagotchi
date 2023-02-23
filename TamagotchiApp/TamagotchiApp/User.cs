using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiApp
{
    class User
    {
        public class UserData
        {
            public int userid { get; set; }
            public string username { get; set; }
        }
        public UserData data { get; set; }
    }
    class Users
    {
        public User.UserData[] data { get; set; }
    }
}
