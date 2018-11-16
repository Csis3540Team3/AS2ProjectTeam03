using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using static AS2ProjectTeam03.DataTypes;

namespace AS2ProjectTeam03
{
    public class RestSharp
    {
        public List<Datum> GetRestData()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://pro-api.coinmarketcap.com/");

            var request = new RestRequest();
            request.Resource = "v1/cryptocurrency/listings/latest";
            request.AddHeader("X-CMC_PRO_API_KEY", "f4b1a6e7-cfbe-4dc4-a241-54f32177f585");
            request.AddParameter("start", "1");
            request.AddParameter("limit", "200");

            IRestResponse<RootObject> response = client.Execute<RootObject>(request);
            //foreach (Datum d in response.Data.data)
            //{
            //    Console.WriteLine($"{d.symbol} {d.max_supply}");
            //}

            IRestResponse responseFull = client.Execute(request);
            
            Console.WriteLine(responseFull.Content);

            return response.Data.data;
        }
    }
}
