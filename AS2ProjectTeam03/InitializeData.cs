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
            string currentCurrency = "CAD";
            // calls a restful request to coinmarketcap api
            List<Datum> initialData = new RestSharp().GetRestData(currentCurrency);
            //declares the var coinRows outside the if... else statement
            IEnumerable<CoinRow> coinRows;
            //condicional for switching currencies
            if (currentCurrency == "CAD")
            {
                coinRows =
                    from data in initialData
                    select new CoinRow
                    {
                        CoinId = data.id,
                        CoinName = data.name,
                        CoinSymbol = data.symbol,
                        //CAD currency conversion
                        CoinQuoteString = data.quote.CAD.price.ToString("C2"),
                        Coin24hrString = (data.quote.CAD.percent_change_24h / 100).ToString("P2")
                    };
            }
            else 
            {
                coinRows =
                    from data in initialData
                    select new CoinRow
                    {
                        CoinId = data.id,
                        CoinName = data.name,
                        CoinSymbol = data.symbol,
                        //USD currency conversion
                        CoinQuoteString = data.quote.USD.price.ToString("C2"),
                        Coin24hrString = (data.quote.USD.percent_change_24h / 100).ToString("P2")
                    };
            }
            //returns a list to map to the gridview
            return coinRows.ToList();
        }
    }
}
