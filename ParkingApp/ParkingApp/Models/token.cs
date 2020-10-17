using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.Services
{
    public class Token
    {
        [JsonProperty("token")]
         public string token;
    }
}
