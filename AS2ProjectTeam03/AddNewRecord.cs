using AS2ProjectTeam03.EF_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2ProjectTeam03
{
    public class AddNewRecord
    {
        static AddNewRecord()
        {
            using (var context = new CoinTrackerEntities())
            {
                try
                {
                    var coin = new Coin()
                    {
                        coinName = "Polis",
                        coinId = 203,
                        coinSymbol = "PPAY",
                        coinMaxSupply = 14000000
                    };
                    context.Coins.Add(coin);
                    context.SaveChanges();
                    Console.WriteLine(coin.coinId);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
        }
    }
}
