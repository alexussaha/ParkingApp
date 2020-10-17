using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Services
{
    class LoginPassword
    {
        [JsonProperty("username")]
        public string login { get; set; }
        [JsonProperty("password")]
        public string password { get; set; }
    }
}
