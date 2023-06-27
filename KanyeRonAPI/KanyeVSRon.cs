using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeRonAPI
{
    public class KanyeVSRon
    {
        public static void Kanye()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"then Kanye said to Ron, '{kanyeQuote}'");
            Console.WriteLine();
        }

        public static void Ron()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse);

            Console.WriteLine($"and then Ron said to Kanye, '{ronQuote[0]}'");
        }
    }
}
