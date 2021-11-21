using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandwich_Shop
{
    public class SandwichLogin
    {

        [JsonProperty("UserData")]
        public UserData UserData { get; set; }



    }


    public class UserData : SandwichLogin
    {

        [JsonProperty("userName")]
        public string userName;


        [JsonProperty("Password")]
        public string Password;

        public UserData()
        {

            userName = "Admin";
            Password = "Admin";
        }


    }
}
