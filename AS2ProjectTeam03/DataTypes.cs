using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2ProjectTeam03
{
    public class DataTypes
    {
        public class Status
        {
            public DateTime timestamp { get; set; }
            public int error_code { get; set; }
            public object error_message { get; set; }
            public int elapsed { get; set; }
            public int credit_count { get; set; }
        }

        public class Currency
        {
            public double price { get; set; }
            public double volume_24h { get; set; }
            public double percent_change_1h { get; set; }
            public double percent_change_24h { get; set; }
            public double percent_change_7d { get; set; }
            public double market_cap { get; set; }
            public DateTime last_updated { get; set; }
        }

        public class Quote
        {
            public Currency CAD { get; set; }
            public Currency USD { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public string symbol { get; set; }
            public string slug { get; set; }
            public double circulating_supply { get; set; }
            public double total_supply { get; set; }
            public long? max_supply { get; set; }
            public DateTime date_added { get; set; }
            public int num_market_pairs { get; set; }
            public int cmc_rank { get; set; }
            public DateTime last_updated { get; set; }
            public Quote quote { get; set; }
        }

        public class RootObject
        {
            public Status status { get; set; }
            public List<Datum> data { get; set; }
        }

        /// <summary>
        ///         used to populate the report gridview
        ///   gridview columns are in order of the fields below.
        ///note use of annotation for displayname which sets the column header text
        /// </summary>
        public class CoinRow
        {
            [DisplayName("Coin ID")]
            public int CoinId { get; set; }
            [DisplayName("Symbol")]
            public string CoinSymbol { get; set; }
            [DisplayName("Name")]
            public string CoinName { get; set; }
            [DisplayName("Quote")]
            public double CoinQuote { get; set; }
            [DisplayName("24hrs Change")]
            public double Coin24hr { get; set; }
            //ToString override
            public override string ToString()
            {
                return $"CoinId: {CoinId}, CoinSymbol: {CoinSymbol}, CoinName: {CoinName}";
            }
        }
    }
}
