using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AS2ProjectTeam03.DataTypes;

namespace AS2ProjectTeam03
{
    public class InitializeData
    {
        public List<CoinRow> GetCoinRows()
        {
            // calls a restful request to coinmarketcap api
            List<Datum> initialData = new RestSharp().GetRestData();

            //a list to map the gridview
            var coinRow =
                from data in initialData
                select new CoinRow
                {
                    CoinId = data.id,
                    CoinName = data.name,
                    CoinSymbol = data.symbol,
                    CoinQuoteString = data.quote.USD.price.ToString("C2"),
                    Coin24hrString = (data.quote.USD.percent_change_24h/100).ToString("P2")
                };
            return coinRow.ToList();
        }
    }
}
