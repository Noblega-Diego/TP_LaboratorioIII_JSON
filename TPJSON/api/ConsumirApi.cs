using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TPJSON.api.models;

namespace TPJSON.api
{
    class ConsumirApi
    {
       public static void Main(string[] args)
        {
            string uri = "https://randomuser.me/api/?results=10";
            WebClient wc = new WebClient();
            string data = wc.DownloadString(uri);
            RootUserApi dataApiUser = JsonConvert.DeserializeObject<RootUserApi>(data);
            foreach(User user in dataApiUser.results)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("name:" + user.name.first);
                Console.WriteLine("last name:" + user.name.last);
                Console.WriteLine("user name:" + user.login.username);
                Console.WriteLine("password:" + user.login.password);
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
