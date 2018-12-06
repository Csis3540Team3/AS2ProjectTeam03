using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AS2ProjectTeam03.DataTypes;

namespace AS2ProjectTeam03
{
    /// <summary>
    /// gets a list of datum and returns a list of coinrows
    /// </summary>
    public class ListDatumToListCoinRow
    {
        public List<CoinRow> GetCoinRows(List<Datum> initialData)
        {
            // calls a restful request to coinmarketcap api
            //List<Datum> initialData = new RestSharp().GetRestData();
            //List<Datum> initialData = new WebApiRequest().GetApiAsync().Result;
            //declares the var coinRows and linq query for needed data
            var coinRows =
                from data in initialData
                select new CoinRow
                {
                    CoinId = data.id,
                    CoinName = data.name,
                    CoinSymbol = data.symbol,
                };
            //returns a list to map to the gridview
            return coinRows.ToList();
        }
    }
}
