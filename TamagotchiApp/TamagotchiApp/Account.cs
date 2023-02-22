using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiApp
{
    class Account
    {
        public class AccountData
        {
            public string token { get; set; }
            public int userid { get; set; }
        }
        public AccountData data { get; set; }
    }
    
}
