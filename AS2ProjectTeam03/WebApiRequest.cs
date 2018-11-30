using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static AS2ProjectTeam03.DataTypes;

namespace AS2ProjectTeam03
{
    class WebApiRequest
    {
        /// <summary>
        /// main method for async request to coinmarketcap
        /// </summary>
        public static async Task<List<Datum>> GetApiAsync()
        {
            //initiate the result list
            List<Datum> resultList = null;
            //initiate a web client
            HttpClient client = new HttpClient();
            //path to get request
            string path = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?start=1&limit=200&convert=CAD&CMC_PRO_API_KEY=f4b1a6e7-cfbe-4dc4-a241-54f32177f585";
            //initiate api async response
            HttpResponseMessage response = await client.GetAsync(path);
            //result into a list
            var apiResult = response.Content.ReadAsStreamAsync();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RootObject));
            MemoryStream stream1 = new MemoryStream();
            StreamReader sr = new StreamReader(stream1);
            jsonSerializer.WriteObject(stream1, apiResult);
            RootObject rootObject = (RootObject)jsonSerializer.ReadObject(stream1);
            //logic
            Console.WriteLine("Hello world");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("helo");
            }
            else
            {
                Console.WriteLine("world");
            }
            return resultList;
        }

    }
}
