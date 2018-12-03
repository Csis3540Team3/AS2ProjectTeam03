using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2ProjectTeam03
{
    public class InitialJson
    {
        public string InitialJsonString { get
            {
                return @"
                {
                ""status"": {
                    ""timestamp"": ""2018-12-03T04:16:55.593Z"",
                    ""error_code"": 0,
                    ""error_message"": null,
                    ""elapsed"": 21,
                    ""credit_count"": 1
                },
                ""data"": [
                    {
                        ""id"": 1,
                        ""name"": ""Bitcoin"",
                        ""symbol"": ""BTC"",
                        ""slug"": ""bitcoin"",
                        ""circulating_supply"": 17404250,
                        ""total_supply"": 17404250,
                        ""max_supply"": 21000000,
                        ""date_added"": ""2013-04-28T00:00:00.000Z"",
                        ""num_market_pairs"": 6611,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 1,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 5305.1212277648665,
                                ""volume_24h"": 6932571782.166503,
                                ""percent_change_1h"": 0.2002,
                                ""percent_change_24h"": -4.4996,
                                ""percent_change_7d"": -0.246,
                                ""market_cap"": 92331656128.32668,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 52,
                        ""name"": ""XRP"",
                        ""symbol"": ""XRP"",
                        ""slug"": ""ripple"",
                        ""circulating_supply"": 40327341704,
                        ""total_supply"": 99991780039,
                        ""max_supply"": 100000000000,
                        ""date_added"": ""2013-08-04T00:00:00.000Z"",
                        ""num_market_pairs"": 265,
                        ""tags"": [],
                        ""cmc_rank"": 2,
                        ""last_updated"": ""2018-12-03T04:16:02.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.47622364597785705,
                                ""volume_24h"": 454697495.0337796,
                                ""percent_change_1h"": 0.1723,
                                ""percent_change_24h"": -3.5106,
                                ""percent_change_7d"": -4.288,
                                ""market_cap"": 19204833698.873768,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1027,
                        ""name"": ""Ethereum"",
                        ""symbol"": ""ETH"",
                        ""slug"": ""ethereum"",
                        ""circulating_supply"": 103567766.0928,
                        ""total_supply"": 103567766.0928,
                        ""max_supply"": null,
                        ""date_added"": ""2015-08-07T00:00:00.000Z"",
                        ""num_market_pairs"": 4674,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 3,
                        ""last_updated"": ""2018-12-03T04:15:19.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 149.9691423526074,
                                ""volume_24h"": 2437613420.503494,
                                ""percent_change_1h"": 0.1071,
                                ""percent_change_24h"": -4.0586,
                                ""percent_change_7d"": -1.8612,
                                ""market_cap"": 15531969056.312672,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 512,
                        ""name"": ""Stellar"",
                        ""symbol"": ""XLM"",
                        ""slug"": ""stellar"",
                        ""circulating_supply"": 19154499773.2621,
                        ""total_supply"": 104503027828.283,
                        ""max_supply"": null,
                        ""date_added"": ""2014-08-05T00:00:00.000Z"",
                        ""num_market_pairs"": 149,
                        ""tags"": [],
                        ""cmc_rank"": 4,
                        ""last_updated"": ""2018-12-03T04:16:05.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.20668512364418906,
                                ""volume_24h"": 99744467.24116175,
                                ""percent_change_1h"": 0.5388,
                                ""percent_change_24h"": -5.7168,
                                ""percent_change_7d"": -0.2622,
                                ""market_cap"": 3958950153.979269,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1831,
                        ""name"": ""Bitcoin Cash"",
                        ""symbol"": ""BCH"",
                        ""slug"": ""bitcoin-cash"",
                        ""circulating_supply"": 17489950,
                        ""total_supply"": 17489950,
                        ""max_supply"": 21000000,
                        ""date_added"": ""2017-07-23T00:00:00.000Z"",
                        ""num_market_pairs"": 161,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 5,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 219.04138770294057,
                                ""volume_24h"": 99119355.21053186,
                                ""percent_change_1h"": 0.1577,
                                ""percent_change_24h"": -4.722,
                                ""percent_change_7d"": -10.1442,
                                ""market_cap"": 3831022918.8550453,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1765,
                        ""name"": ""EOS"",
                        ""symbol"": ""EOS"",
                        ""slug"": ""eos"",
                        ""circulating_supply"": 906245117.6,
                        ""total_supply"": 1006245119.9339,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-01T00:00:00.000Z"",
                        ""num_market_pairs"": 200,
                        ""tags"": [],
                        ""cmc_rank"": 6,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 3.7618572446008827,
                                ""volume_24h"": 992877916.795907,
                                ""percent_change_1h"": 0.7679,
                                ""percent_change_24h"": -4.3078,
                                ""percent_change_7d"": -17.981,
                                ""market_cap"": 3409164761.0277395,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2,
                        ""name"": ""Litecoin"",
                        ""symbol"": ""LTC"",
                        ""slug"": ""litecoin"",
                        ""circulating_supply"": 59406663.4828513,
                        ""total_supply"": 59406663.4828513,
                        ""max_supply"": 84000000,
                        ""date_added"": ""2013-04-28T00:00:00.000Z"",
                        ""num_market_pairs"": 699,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 7,
                        ""last_updated"": ""2018-12-03T04:16:03.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 43.03982552406186,
                                ""volume_24h"": 544346301.3794608,
                                ""percent_change_1h"": 0.6773,
                                ""percent_change_24h"": -5.1744,
                                ""percent_change_7d"": 3.9227,
                                ""market_cap"": 2556852431.268577,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 825,
                        ""name"": ""Tether"",
                        ""symbol"": ""USDT"",
                        ""slug"": ""tether"",
                        ""circulating_supply"": 1856421735.6243,
                        ""total_supply"": 2580109502.1043,
                        ""max_supply"": null,
                        ""date_added"": ""2015-02-25T00:00:00.000Z"",
                        ""num_market_pairs"": 1478,
                        ""tags"": [],
                        ""cmc_rank"": 8,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.3150390134597307,
                                ""volume_24h"": 4298690019.699285,
                                ""percent_change_1h"": -0.1871,
                                ""percent_change_24h"": -0.3923,
                                ""percent_change_7d"": 1.3198,
                                ""market_cap"": 2441267007.7805805,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3602,
                        ""name"": ""Bitcoin SV"",
                        ""symbol"": ""BSV"",
                        ""slug"": ""bitcoin-sv"",
                        ""circulating_supply"": 17477860.9418,
                        ""total_supply"": 17477860.9418,
                        ""max_supply"": 21000000,
                        ""date_added"": ""2018-11-09T00:00:00.000Z"",
                        ""num_market_pairs"": 81,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 9,
                        ""last_updated"": ""2018-12-03T04:15:37.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 125.09706042644504,
                                ""volume_24h"": 151696534.45406422,
                                ""percent_change_1h"": -0.2436,
                                ""percent_change_24h"": -0.3985,
                                ""percent_change_7d"": -2.0876,
                                ""market_cap"": 2186429026.361358,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2010,
                        ""name"": ""Cardano"",
                        ""symbol"": ""ADA"",
                        ""slug"": ""cardano"",
                        ""circulating_supply"": 25927070538,
                        ""total_supply"": 31112483745,
                        ""max_supply"": 45000000000,
                        ""date_added"": ""2017-10-01T00:00:00.000Z"",
                        ""num_market_pairs"": 63,
                        ""tags"": [],
                        ""cmc_rank"": 10,
                        ""last_updated"": ""2018-12-03T04:15:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.05364773820601492,
                                ""volume_24h"": 27557456.980097767,
                                ""percent_change_1h"": 0.7661,
                                ""percent_change_24h"": -3.198,
                                ""percent_change_7d"": 6.5218,
                                ""market_cap"": 1390928692.6715064,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 328,
                        ""name"": ""Monero"",
                        ""symbol"": ""XMR"",
                        ""slug"": ""monero"",
                        ""circulating_supply"": 16616162.31818,
                        ""total_supply"": 16616162.31818,
                        ""max_supply"": null,
                        ""date_added"": ""2014-05-21T00:00:00.000Z"",
                        ""num_market_pairs"": 106,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 11,
                        ""last_updated"": ""2018-12-03T04:16:05.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 75.81961265314641,
                                ""volume_24h"": 15085811.873166053,
                                ""percent_change_1h"": 0.6594,
                                ""percent_change_24h"": -4.657,
                                ""percent_change_7d"": -2.2614,
                                ""market_cap"": 1259830990.7462149,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1958,
                        ""name"": ""TRON"",
                        ""symbol"": ""TRX"",
                        ""slug"": ""tron"",
                        ""circulating_supply"": 66142846237.8871,
                        ""total_supply"": 99211756993.5176,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-13T00:00:00.000Z"",
                        ""num_market_pairs"": 150,
                        ""tags"": [],
                        ""cmc_rank"": 12,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.018963037566087856,
                                ""volume_24h"": 80428207.28343086,
                                ""percent_change_1h"": 0.2346,
                                ""percent_change_24h"": -5.1464,
                                ""percent_change_7d"": 13.3977,
                                ""market_cap"": 1254269277.937026,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1720,
                        ""name"": ""IOTA"",
                        ""symbol"": ""MIOTA"",
                        ""slug"": ""iota"",
                        ""circulating_supply"": 2779530283,
                        ""total_supply"": 2779530283,
                        ""max_supply"": 2779530283,
                        ""date_added"": ""2017-06-13T00:00:00.000Z"",
                        ""num_market_pairs"": 34,
                        ""tags"": [],
                        ""cmc_rank"": 13,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3783858368983567,
                                ""volume_24h"": 9463953.532687692,
                                ""percent_change_1h"": 0.2496,
                                ""percent_change_24h"": -6.086,
                                ""percent_change_7d"": -0.0739,
                                ""market_cap"": 1051734892.3172811,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 131,
                        ""name"": ""Dash"",
                        ""symbol"": ""DASH"",
                        ""slug"": ""dash"",
                        ""circulating_supply"": 8483834.83660632,
                        ""total_supply"": 8483834.83660632,
                        ""max_supply"": 18900000,
                        ""date_added"": ""2014-02-14T00:00:00.000Z"",
                        ""num_market_pairs"": 191,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 14,
                        ""last_updated"": ""2018-12-03T04:16:05.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 119.43572859781035,
                                ""volume_24h"": 222000046.61493725,
                                ""percent_change_1h"": -0.0748,
                                ""percent_change_24h"": -5.2763,
                                ""percent_change_7d"": -2.4143,
                                ""market_cap"": 1013272995.0135612,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1839,
                        ""name"": ""Binance Coin"",
                        ""symbol"": ""BNB"",
                        ""slug"": ""binance-coin"",
                        ""circulating_supply"": 130799315.0005,
                        ""total_supply"": 190799315,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-25T00:00:00.000Z"",
                        ""num_market_pairs"": 104,
                        ""tags"": [],
                        ""cmc_rank"": 15,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 6.81392307962772,
                                ""volume_24h"": 16019589.731795417,
                                ""percent_change_1h"": 1.2458,
                                ""percent_change_24h"": -2.6441,
                                ""percent_change_7d"": -0.0394,
                                ""market_cap"": 891256471.2814032,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 873,
                        ""name"": ""NEM"",
                        ""symbol"": ""XEM"",
                        ""slug"": ""nem"",
                        ""circulating_supply"": 8999999999,
                        ""total_supply"": 8999999999,
                        ""max_supply"": null,
                        ""date_added"": ""2015-04-01T00:00:00.000Z"",
                        ""num_market_pairs"": 71,
                        ""tags"": [],
                        ""cmc_rank"": 16,
                        ""last_updated"": ""2018-12-03T04:16:06.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.09910368289586798,
                                ""volume_24h"": 11290095.585338272,
                                ""percent_change_1h"": 0.0361,
                                ""percent_change_24h"": -4.0375,
                                ""percent_change_7d"": 6.9577,
                                ""market_cap"": 891933145.963708,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1321,
                        ""name"": ""Ethereum Classic"",
                        ""symbol"": ""ETC"",
                        ""slug"": ""ethereum-classic"",
                        ""circulating_supply"": 106477726,
                        ""total_supply"": 106477726,
                        ""max_supply"": null,
                        ""date_added"": ""2016-07-24T00:00:00.000Z"",
                        ""num_market_pairs"": 167,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 17,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 6.671699636217804,
                                ""volume_24h"": 254692599.60315928,
                                ""percent_change_1h"": 0.5551,
                                ""percent_change_24h"": 2.9956,
                                ""percent_change_7d"": 5.7319,
                                ""market_cap"": 710387405.819499,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1376,
                        ""name"": ""NEO"",
                        ""symbol"": ""NEO"",
                        ""slug"": ""neo"",
                        ""circulating_supply"": 65000000,
                        ""total_supply"": 100000000,
                        ""max_supply"": 100000000,
                        ""date_added"": ""2016-09-08T00:00:00.000Z"",
                        ""num_market_pairs"": 145,
                        ""tags"": [],
                        ""cmc_rank"": 18,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 10.31128887764771,
                                ""volume_24h"": 172497685.84178993,
                                ""percent_change_1h"": 0.6544,
                                ""percent_change_24h"": -5.3187,
                                ""percent_change_7d"": 1.3624,
                                ""market_cap"": 670233777.0471011,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1437,
                        ""name"": ""Zcash"",
                        ""symbol"": ""ZEC"",
                        ""slug"": ""zcash"",
                        ""circulating_supply"": 5366381.25,
                        ""total_supply"": 5366381.25,
                        ""max_supply"": null,
                        ""date_added"": ""2016-10-29T00:00:00.000Z"",
                        ""num_market_pairs"": 131,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 19,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 102.32754456756916,
                                ""volume_24h"": 236454110.13561222,
                                ""percent_change_1h"": 0.3777,
                                ""percent_change_24h"": -3.7124,
                                ""percent_change_7d"": 8.8646,
                                ""market_cap"": 549128616.5259426,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2083,
                        ""name"": ""Bitcoin Gold"",
                        ""symbol"": ""BTG"",
                        ""slug"": ""bitcoin-gold"",
                        ""circulating_supply"": 17375848.588994,
                        ""total_supply"": 17475848.588994,
                        ""max_supply"": 21000000,
                        ""date_added"": ""2017-10-23T00:00:00.000Z"",
                        ""num_market_pairs"": 78,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 20,
                        ""last_updated"": ""2018-12-03T04:15:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 23.46834276000793,
                                ""volume_24h"": 6354155.200438895,
                                ""percent_change_1h"": 0.2034,
                                ""percent_change_24h"": -5.1718,
                                ""percent_change_7d"": -8.2967,
                                ""market_cap"": 407782370.4325113,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2011,
                        ""name"": ""Tezos"",
                        ""symbol"": ""XTZ"",
                        ""slug"": ""tezos"",
                        ""circulating_supply"": 607489040.89,
                        ""total_supply"": 763306929.69,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-02T00:00:00.000Z"",
                        ""num_market_pairs"": 24,
                        ""tags"": [],
                        ""cmc_rank"": 21,
                        ""last_updated"": ""2018-12-03T04:15:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.6236268218847308,
                                ""volume_24h"": 1927551.247117745,
                                ""percent_change_1h"": 0.0785,
                                ""percent_change_24h"": -5.6405,
                                ""percent_change_7d"": -25.5401,
                                ""market_cap"": 378846459.90003395,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1518,
                        ""name"": ""Maker"",
                        ""symbol"": ""MKR"",
                        ""slug"": ""maker"",
                        ""circulating_supply"": 728227.770105802,
                        ""total_supply"": 1000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-01-29T00:00:00.000Z"",
                        ""num_market_pairs"": 29,
                        ""tags"": [],
                        ""cmc_rank"": 22,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 511.67943409174035,
                                ""volume_24h"": 413643.1240268014,
                                ""percent_change_1h"": 0.0158,
                                ""percent_change_24h"": -1.2817,
                                ""percent_change_7d"": 17.109,
                                ""market_cap"": 372619173.2976267,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3077,
                        ""name"": ""VeChain"",
                        ""symbol"": ""VET"",
                        ""slug"": ""vechain"",
                        ""circulating_supply"": 55454734800,
                        ""total_supply"": 86712634466,
                        ""max_supply"": null,
                        ""date_added"": ""2017-08-22T00:00:00.000Z"",
                        ""num_market_pairs"": 27,
                        ""tags"": [],
                        ""cmc_rank"": 23,
                        ""last_updated"": ""2018-12-03T04:15:31.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.006286499573902911,
                                ""volume_24h"": 9682799.44752222,
                                ""percent_change_1h"": 1.2392,
                                ""percent_change_24h"": -6.1851,
                                ""percent_change_7d"": 2.2413,
                                ""market_cap"": 348616166.6910989,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 74,
                        ""name"": ""Dogecoin"",
                        ""symbol"": ""DOGE"",
                        ""slug"": ""dogecoin"",
                        ""circulating_supply"": 117237641286.303,
                        ""total_supply"": 117237641286.303,
                        ""max_supply"": null,
                        ""date_added"": ""2013-12-15T00:00:00.000Z"",
                        ""num_market_pairs"": 454,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 24,
                        ""last_updated"": ""2018-12-03T04:16:04.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.002911095836395582,
                                ""volume_24h"": 12524302.418291474,
                                ""percent_change_1h"": 0.1023,
                                ""percent_change_24h"": -1.6539,
                                ""percent_change_7d"": -0.3246,
                                ""market_cap"": 341290009.4173954,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2566,
                        ""name"": ""Ontology"",
                        ""symbol"": ""ONT"",
                        ""slug"": ""ontology"",
                        ""circulating_supply"": 291115881,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-08T00:00:00.000Z"",
                        ""num_market_pairs"": 46,
                        ""tags"": [],
                        ""cmc_rank"": 25,
                        ""last_updated"": ""2018-12-03T04:15:24.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.0399613457011978,
                                ""volume_24h"": 46343202.630906805,
                                ""percent_change_1h"": 0.084,
                                ""percent_change_24h"": -4.3906,
                                ""percent_change_7d"": -9.5422,
                                ""market_cap"": 302749263.35974973,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1896,
                        ""name"": ""0x"",
                        ""symbol"": ""ZRX"",
                        ""slug"": ""0x"",
                        ""circulating_supply"": 551277302.448171,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-08-16T00:00:00.000Z"",
                        ""num_market_pairs"": 109,
                        ""tags"": [],
                        ""cmc_rank"": 26,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.5152943751443332,
                                ""volume_24h"": 12067123.24434484,
                                ""percent_change_1h"": 0.0523,
                                ""percent_change_24h"": -7.1003,
                                ""percent_change_7d"": 4.2954,
                                ""market_cap"": 284070093.09628385,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1808,
                        ""name"": ""OmiseGO"",
                        ""symbol"": ""OMG"",
                        ""slug"": ""omisego"",
                        ""circulating_supply"": 140245398.245133,
                        ""total_supply"": 140245398.245133,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-14T00:00:00.000Z"",
                        ""num_market_pairs"": 141,
                        ""tags"": [],
                        ""cmc_rank"": 27,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 2.0037401032927713,
                                ""volume_24h"": 28876040.35932427,
                                ""percent_change_1h"": 0.066,
                                ""percent_change_24h"": -6.9389,
                                ""percent_change_7d"": -0.1046,
                                ""market_cap"": 281015328.76603866,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1697,
                        ""name"": ""Basic Attention Token"",
                        ""symbol"": ""BAT"",
                        ""slug"": ""basic-attention-token"",
                        ""circulating_supply"": 1180848539.91923,
                        ""total_supply"": 1500000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-01T00:00:00.000Z"",
                        ""num_market_pairs"": 61,
                        ""tags"": [],
                        ""cmc_rank"": 28,
                        ""last_updated"": ""2018-12-03T04:16:10.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.2253861107268983,
                                ""volume_24h"": 7624815.188252041,
                                ""percent_change_1h"": -0.6807,
                                ""percent_change_24h"": -3.1621,
                                ""percent_change_7d"": 12.7731,
                                ""market_cap"": 266146859.76993176,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2563,
                        ""name"": ""TrueUSD"",
                        ""symbol"": ""TUSD"",
                        ""slug"": ""trueusd"",
                        ""circulating_supply"": 195050842.89,
                        ""total_supply"": 195050842.89,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-06T00:00:00.000Z"",
                        ""num_market_pairs"": 102,
                        ""tags"": [],
                        ""cmc_rank"": 29,
                        ""last_updated"": ""2018-12-03T04:15:23.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.3416584290802174,
                                ""volume_24h"": 30634020.46201366,
                                ""percent_change_1h"": 0.177,
                                ""percent_change_24h"": -0.0307,
                                ""percent_change_7d"": -0.0582,
                                ""market_cap"": 261691607.46256965,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1684,
                        ""name"": ""Qtum"",
                        ""symbol"": ""QTUM"",
                        ""slug"": ""qtum"",
                        ""circulating_supply"": 89079488,
                        ""total_supply"": 101079488,
                        ""max_supply"": null,
                        ""date_added"": ""2017-05-24T00:00:00.000Z"",
                        ""num_market_pairs"": 152,
                        ""tags"": [],
                        ""cmc_rank"": 30,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 2.6892084567680894,
                                ""volume_24h"": 207490958.50901237,
                                ""percent_change_1h"": 0.8279,
                                ""percent_change_24h"": -4.6795,
                                ""percent_change_7d"": -2.0537,
                                ""market_cap"": 239553312.45417157,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3408,
                        ""name"": ""USD Coin"",
                        ""symbol"": ""USDC"",
                        ""slug"": ""usd-coin"",
                        ""circulating_supply"": 176526497.694729,
                        ""total_supply"": 177190288.61,
                        ""max_supply"": null,
                        ""date_added"": ""2018-10-08T00:00:00.000Z"",
                        ""num_market_pairs"": 41,
                        ""tags"": [],
                        ""cmc_rank"": 31,
                        ""last_updated"": ""2018-12-03T04:15:32.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.3364500641936026,
                                ""volume_24h"": 15080266.475694822,
                                ""percent_change_1h"": -0.0722,
                                ""percent_change_24h"": 0.0416,
                                ""percent_change_7d"": -1.1283,
                                ""market_cap"": 235918849.1759924,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1168,
                        ""name"": ""Decred"",
                        ""symbol"": ""DCR"",
                        ""slug"": ""decred"",
                        ""circulating_supply"": 8916465.79208478,
                        ""total_supply"": 8916465.79208478,
                        ""max_supply"": 21000000,
                        ""date_added"": ""2016-02-10T00:00:00.000Z"",
                        ""num_market_pairs"": 32,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 32,
                        ""last_updated"": ""2018-12-03T04:16:07.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 26.327198323707613,
                                ""volume_24h"": 1207572.0719621526,
                                ""percent_change_1h"": 0.4567,
                                ""percent_change_24h"": -5.1879,
                                ""percent_change_7d"": -6.3362,
                                ""market_cap"": 234745563.2547707,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3330,
                        ""name"": ""Paxos Standard Token"",
                        ""symbol"": ""PAX"",
                        ""slug"": ""paxos-standard-token"",
                        ""circulating_supply"": 170703166.532223,
                        ""total_supply"": 171473057.5,
                        ""max_supply"": null,
                        ""date_added"": ""2018-09-27T00:00:00.000Z"",
                        ""num_market_pairs"": 48,
                        ""tags"": [],
                        ""cmc_rank"": 33,
                        ""last_updated"": ""2018-12-03T04:15:32.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.3364888841993572,
                                ""volume_24h"": 92802996.81932035,
                                ""percent_change_1h"": -0.0034,
                                ""percent_change_24h"": -0.2693,
                                ""percent_change_7d"": -0.0868,
                                ""market_cap"": 228142884.56794772,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1214,
                        ""name"": ""Lisk"",
                        ""symbol"": ""LSK"",
                        ""slug"": ""lisk"",
                        ""circulating_supply"": 112707556.719029,
                        ""total_supply"": 127826110,
                        ""max_supply"": null,
                        ""date_added"": ""2016-04-06T00:00:00.000Z"",
                        ""num_market_pairs"": 56,
                        ""tags"": [],
                        ""cmc_rank"": 34,
                        ""last_updated"": ""2018-12-03T04:16:07.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.8646341516184377,
                                ""volume_24h"": 4428508.029852794,
                                ""percent_change_1h"": -0.0631,
                                ""percent_change_24h"": -6.1015,
                                ""percent_change_7d"": 1.1695,
                                ""market_cap"": 210158359.40377358,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2222,
                        ""name"": ""Bitcoin Diamond"",
                        ""symbol"": ""BCD"",
                        ""slug"": ""bitcoin-diamond"",
                        ""circulating_supply"": 153756875,
                        ""total_supply"": 156756875,
                        ""max_supply"": 210000000,
                        ""date_added"": ""2017-11-24T00:00:00.000Z"",
                        ""num_market_pairs"": 21,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 35,
                        ""last_updated"": ""2018-12-03T04:15:16.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.3019132438244148,
                                ""volume_24h"": 1552164.3260605403,
                                ""percent_change_1h"": -0.0376,
                                ""percent_change_24h"": -3.2842,
                                ""percent_change_7d"": -8.981,
                                ""market_cap"": 200178111.89155507,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 372,
                        ""name"": ""Bytecoin"",
                        ""symbol"": ""BCN"",
                        ""slug"": ""bytecoin-bcn"",
                        ""circulating_supply"": 184066828814.059,
                        ""total_supply"": 184066828814.059,
                        ""max_supply"": 184470000000,
                        ""date_added"": ""2014-06-17T00:00:00.000Z"",
                        ""num_market_pairs"": 14,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 36,
                        ""last_updated"": ""2018-12-03T04:16:04.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0010707567644813087,
                                ""volume_24h"": 228676.0518896135,
                                ""percent_change_1h"": 0.0886,
                                ""percent_change_24h"": -6.2425,
                                ""percent_change_7d"": -0.2488,
                                ""market_cap"": 197090802.06927675,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1274,
                        ""name"": ""Waves"",
                        ""symbol"": ""WAVES"",
                        ""slug"": ""waves"",
                        ""circulating_supply"": 100000000,
                        ""total_supply"": 100000000,
                        ""max_supply"": null,
                        ""date_added"": ""2016-06-02T00:00:00.000Z"",
                        ""num_market_pairs"": 102,
                        ""tags"": [],
                        ""cmc_rank"": 37,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.9175536211719488,
                                ""volume_24h"": 19717520.330722567,
                                ""percent_change_1h"": -8.0762,
                                ""percent_change_24h"": 1.1048,
                                ""percent_change_7d"": 27.5813,
                                ""market_cap"": 191755362.1171949,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 109,
                        ""name"": ""DigiByte"",
                        ""symbol"": ""DGB"",
                        ""slug"": ""digibyte"",
                        ""circulating_supply"": 11130733152.4039,
                        ""total_supply"": 11130733152.4039,
                        ""max_supply"": 21000000000,
                        ""date_added"": ""2014-02-06T00:00:00.000Z"",
                        ""num_market_pairs"": 56,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 38,
                        ""last_updated"": ""2018-12-03T04:16:04.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.01673936755828297,
                                ""volume_24h"": 1358780.841919153,
                                ""percent_change_1h"": -0.597,
                                ""percent_change_24h"": -7.883,
                                ""percent_change_7d"": 12.0568,
                                ""market_cap"": 186321433.4312546,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2469,
                        ""name"": ""Zilliqa"",
                        ""symbol"": ""ZIL"",
                        ""slug"": ""zilliqa"",
                        ""circulating_supply"": 8044753461.80944,
                        ""total_supply"": 12599999804.24,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-25T00:00:00.000Z"",
                        ""num_market_pairs"": 71,
                        ""tags"": [],
                        ""cmc_rank"": 39,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.022572235752101672,
                                ""volume_24h"": 7724626.710715382,
                                ""percent_change_1h"": 0.6887,
                                ""percent_change_24h"": -6.9483,
                                ""percent_change_7d"": 12.7499,
                                ""market_cap"": 181588071.70749873,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1567,
                        ""name"": ""Nano"",
                        ""symbol"": ""NANO"",
                        ""slug"": ""nano"",
                        ""circulating_supply"": 133248289.1965,
                        ""total_supply"": 133248289.1965,
                        ""max_supply"": 133248290,
                        ""date_added"": ""2017-03-06T00:00:00.000Z"",
                        ""num_market_pairs"": 43,
                        ""tags"": [],
                        ""cmc_rank"": 40,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.32568902947738,
                                ""volume_24h"": 1817238.8679184488,
                                ""percent_change_1h"": 0.417,
                                ""percent_change_24h"": -6.8055,
                                ""percent_change_7d"": -0.4369,
                                ""market_cap"": 176645795.18442935,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1700,
                        ""name"": ""Aeternity"",
                        ""symbol"": ""AE"",
                        ""slug"": ""aeternity"",
                        ""circulating_supply"": 233020472.114,
                        ""total_supply"": 273685830.164,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-01T00:00:00.000Z"",
                        ""num_market_pairs"": 46,
                        ""tags"": [],
                        ""cmc_rank"": 41,
                        ""last_updated"": ""2018-12-03T04:16:10.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.727660665640182,
                                ""volume_24h"": 7439374.297247028,
                                ""percent_change_1h"": 1.5397,
                                ""percent_change_24h"": -2.7975,
                                ""percent_change_7d"": -5.4375,
                                ""market_cap"": 169559831.8462627,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 463,
                        ""name"": ""BitShares"",
                        ""symbol"": ""BTS"",
                        ""slug"": ""bitshares"",
                        ""circulating_supply"": 2676810000,
                        ""total_supply"": 2676810000,
                        ""max_supply"": 3600570502,
                        ""date_added"": ""2014-07-21T00:00:00.000Z"",
                        ""num_market_pairs"": 78,
                        ""tags"": [],
                        ""cmc_rank"": 42,
                        ""last_updated"": ""2018-12-03T04:16:05.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.06336225153428866,
                                ""volume_24h"": 3665517.431673341,
                                ""percent_change_1h"": -0.055,
                                ""percent_change_24h"": -2.6081,
                                ""percent_change_7d"": -0.703,
                                ""market_cap"": 169608708.52949926,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2099,
                        ""name"": ""ICON"",
                        ""symbol"": ""ICX"",
                        ""slug"": ""icon"",
                        ""circulating_supply"": 473406687.603972,
                        ""total_supply"": 800460000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-27T00:00:00.000Z"",
                        ""num_market_pairs"": 36,
                        ""tags"": [],
                        ""cmc_rank"": 43,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3456186774123469,
                                ""volume_24h"": 6929856.785951706,
                                ""percent_change_1h"": 0.0806,
                                ""percent_change_24h"": -6.5938,
                                ""percent_change_7d"": 6.9118,
                                ""market_cap"": 163618193.2478449,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2874,
                        ""name"": ""Aurora"",
                        ""symbol"": ""AOA"",
                        ""slug"": ""aurora"",
                        ""circulating_supply"": 6542330148.20859,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-06-26T00:00:00.000Z"",
                        ""num_market_pairs"": 9,
                        ""tags"": [],
                        ""cmc_rank"": 44,
                        ""last_updated"": ""2018-12-03T04:15:26.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.022876205066313406,
                                ""volume_24h"": 672096.4411009424,
                                ""percent_change_1h"": -0.5632,
                                ""percent_change_24h"": -4.6154,
                                ""percent_change_7d"": -10.2022,
                                ""market_cap"": 149663686.0819443,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 693,
                        ""name"": ""Verge"",
                        ""symbol"": ""XVG"",
                        ""slug"": ""verge"",
                        ""circulating_supply"": 15172086051.1052,
                        ""total_supply"": 15172086051.1052,
                        ""max_supply"": 16555000000,
                        ""date_added"": ""2014-10-25T00:00:00.000Z"",
                        ""num_market_pairs"": 59,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 45,
                        ""last_updated"": ""2018-12-03T04:16:06.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.009829999273464663,
                                ""volume_24h"": 3603892.3090751935,
                                ""percent_change_1h"": -0.5788,
                                ""percent_change_24h"": -6.9677,
                                ""percent_change_7d"": 20.1686,
                                ""market_cap"": 149141594.85930747,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1042,
                        ""name"": ""Siacoin"",
                        ""symbol"": ""SC"",
                        ""slug"": ""siacoin"",
                        ""circulating_supply"": 38235502230,
                        ""total_supply"": 38235502230,
                        ""max_supply"": null,
                        ""date_added"": ""2015-08-26T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 46,
                        ""last_updated"": ""2018-12-03T04:16:07.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0038556547260573336,
                                ""volume_24h"": 1133018.302666757,
                                ""percent_change_1h"": -0.2138,
                                ""percent_change_24h"": -7.7679,
                                ""percent_change_7d"": 2.458,
                                ""market_cap"": 147422894.8762752,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1975,
                        ""name"": ""Chainlink"",
                        ""symbol"": ""LINK"",
                        ""slug"": ""chainlink"",
                        ""circulating_supply"": 350000000,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-20T00:00:00.000Z"",
                        ""num_market_pairs"": 23,
                        ""tags"": [],
                        ""cmc_rank"": 47,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.4070958559321819,
                                ""volume_24h"": 1629700.1686467098,
                                ""percent_change_1h"": 0.6745,
                                ""percent_change_24h"": -8.4337,
                                ""percent_change_7d"": 13.4934,
                                ""market_cap"": 142483549.57626367,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2603,
                        ""name"": ""Pundi X"",
                        ""symbol"": ""NPXS"",
                        ""slug"": ""pundi-x"",
                        ""circulating_supply"": 155239496088.326,
                        ""total_supply"": 280255193861,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-22T00:00:00.000Z"",
                        ""num_market_pairs"": 32,
                        ""tags"": [],
                        ""cmc_rank"": 48,
                        ""last_updated"": ""2018-12-03T04:15:24.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0008651405860253721,
                                ""volume_24h"": 3235022.916676494,
                                ""percent_change_1h"": 0.5441,
                                ""percent_change_24h"": -3.4504,
                                ""percent_change_7d"": -0.1177,
                                ""market_cap"": 134303988.6201378,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1230,
                        ""name"": ""Steem"",
                        ""symbol"": ""STEEM"",
                        ""slug"": ""steem"",
                        ""circulating_supply"": 301189390.497,
                        ""total_supply"": 318163484.497,
                        ""max_supply"": null,
                        ""date_added"": ""2016-04-18T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [],
                        ""cmc_rank"": 49,
                        ""last_updated"": ""2018-12-03T04:16:07.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.44302567097418305,
                                ""volume_24h"": 1595623.8003039504,
                                ""percent_change_1h"": 0.3031,
                                ""percent_change_24h"": -13.9717,
                                ""percent_change_7d"": -4.9821,
                                ""market_cap"": 133434631.81523864,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1866,
                        ""name"": ""Bytom"",
                        ""symbol"": ""BTM"",
                        ""slug"": ""bytom"",
                        ""circulating_supply"": 1002499275,
                        ""total_supply"": 1407000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-08-08T00:00:00.000Z"",
                        ""num_market_pairs"": 37,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 50,
                        ""last_updated"": ""2018-12-03T04:15:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.1304765751086486,
                                ""volume_24h"": 10767614.330891607,
                                ""percent_change_1h"": -0.1482,
                                ""percent_change_24h"": -3.1043,
                                ""percent_change_7d"": -1.825,
                                ""market_cap"": 130802671.95090327,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1087,
                        ""name"": ""Factom"",
                        ""symbol"": ""FCT"",
                        ""slug"": ""factom"",
                        ""circulating_supply"": 8745102,
                        ""total_supply"": 8745102,
                        ""max_supply"": null,
                        ""date_added"": ""2015-10-06T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [],
                        ""cmc_rank"": 51,
                        ""last_updated"": ""2018-12-03T04:16:06.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 14.512365809645553,
                                ""volume_24h"": 901909.7936152007,
                                ""percent_change_1h"": 0.1408,
                                ""percent_change_24h"": -11.7803,
                                ""percent_change_7d"": 8.9165,
                                ""market_cap"": 126912119.26666294,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1104,
                        ""name"": ""Augur"",
                        ""symbol"": ""REP"",
                        ""slug"": ""augur"",
                        ""circulating_supply"": 11000000,
                        ""total_supply"": 11000000,
                        ""max_supply"": null,
                        ""date_added"": ""2015-10-27T00:00:00.000Z"",
                        ""num_market_pairs"": 55,
                        ""tags"": [],
                        ""cmc_rank"": 52,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 10.800215348372442,
                                ""volume_24h"": 1701479.5213347862,
                                ""percent_change_1h"": -0.0245,
                                ""percent_change_24h"": -6.5277,
                                ""percent_change_7d"": -0.6863,
                                ""market_cap"": 118802368.83209684,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1789,
                        ""name"": ""Populous"",
                        ""symbol"": ""PPT"",
                        ""slug"": ""populous"",
                        ""circulating_supply"": 53252245.9943896,
                        ""total_supply"": 53252246,
                        ""max_supply"": 53252246,
                        ""date_added"": ""2017-07-10T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [],
                        ""cmc_rank"": 53,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 2.2099844917691978,
                                ""volume_24h"": 1332999.2288001853,
                                ""percent_change_1h"": -0.4753,
                                ""percent_change_24h"": -10.1514,
                                ""percent_change_7d"": 6.6119,
                                ""market_cap"": 117686637.79947941,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1455,
                        ""name"": ""Golem"",
                        ""symbol"": ""GNT"",
                        ""slug"": ""golem-network-tokens"",
                        ""circulating_supply"": 959842000,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2016-11-18T00:00:00.000Z"",
                        ""num_market_pairs"": 70,
                        ""tags"": [],
                        ""cmc_rank"": 54,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.11854773019445143,
                                ""volume_24h"": 55964078.796186976,
                                ""percent_change_1h"": 0.347,
                                ""percent_change_24h"": -0.9738,
                                ""percent_change_7d"": 4.8963,
                                ""market_cap"": 113787090.44530267,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1521,
                        ""name"": ""Komodo"",
                        ""symbol"": ""KMD"",
                        ""slug"": ""komodo"",
                        ""circulating_supply"": 110866513.83585,
                        ""total_supply"": 110866513.83585,
                        ""max_supply"": null,
                        ""date_added"": ""2017-02-05T00:00:00.000Z"",
                        ""num_market_pairs"": 15,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 55,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9258481447438159,
                                ""volume_24h"": 2269697.009165004,
                                ""percent_change_1h"": 0.343,
                                ""percent_change_24h"": -0.0129,
                                ""percent_change_7d"": 18.3474,
                                ""market_cap"": 102645556.14913632,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1343,
                        ""name"": ""Stratis"",
                        ""symbol"": ""STRAT"",
                        ""slug"": ""stratis"",
                        ""circulating_supply"": 99116749.1811562,
                        ""total_supply"": 99116749.1811562,
                        ""max_supply"": null,
                        ""date_added"": ""2016-08-12T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [],
                        ""cmc_rank"": 56,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.0097788229762303,
                                ""volume_24h"": 1266657.3935089298,
                                ""percent_change_1h"": 0.0555,
                                ""percent_change_24h"": -2.4687,
                                ""percent_change_7d"": 8.7451,
                                ""market_cap"": 100085994.32537815,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2213,
                        ""name"": ""QASH"",
                        ""symbol"": ""QASH"",
                        ""slug"": ""qash"",
                        ""circulating_supply"": 350000000,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-11-21T00:00:00.000Z"",
                        ""num_market_pairs"": 33,
                        ""tags"": [],
                        ""cmc_rank"": 57,
                        ""last_updated"": ""2018-12-03T04:15:16.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.2857239693640132,
                                ""volume_24h"": 590852.9468258447,
                                ""percent_change_1h"": 0.2958,
                                ""percent_change_24h"": -0.0992,
                                ""percent_change_7d"": 6.8782,
                                ""market_cap"": 100003389.2774046,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2137,
                        ""name"": ""Electroneum"",
                        ""symbol"": ""ETN"",
                        ""slug"": ""electroneum"",
                        ""circulating_supply"": 8456969994.23,
                        ""total_supply"": 8456969994.23,
                        ""max_supply"": 21000000000,
                        ""date_added"": ""2017-11-02T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 58,
                        ""last_updated"": ""2018-12-03T04:15:16.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.010899400619423037,
                                ""volume_24h"": 184381.4102146054,
                                ""percent_change_1h"": -0.4765,
                                ""percent_change_24h"": -5.089,
                                ""percent_change_7d"": -2.9993,
                                ""market_cap"": 92175903.9935525,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2682,
                        ""name"": ""Holo"",
                        ""symbol"": ""HOT"",
                        ""slug"": ""holo"",
                        ""circulating_supply"": 133214575156,
                        ""total_supply"": 177619433541.141,
                        ""max_supply"": null,
                        ""date_added"": ""2018-04-29T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [],
                        ""cmc_rank"": 59,
                        ""last_updated"": ""2018-12-03T04:15:24.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0006866330573786872,
                                ""volume_24h"": 1768578.2338839036,
                                ""percent_change_1h"": 1.1088,
                                ""percent_change_24h"": -4.3484,
                                ""percent_change_7d"": -2.5269,
                                ""market_cap"": 91469531.02676718,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 291,
                        ""name"": ""MaidSafeCoin"",
                        ""symbol"": ""MAID"",
                        ""slug"": ""maidsafecoin"",
                        ""circulating_supply"": 452552412,
                        ""total_supply"": 452552412,
                        ""max_supply"": null,
                        ""date_added"": ""2014-04-28T00:00:00.000Z"",
                        ""num_market_pairs"": 7,
                        ""tags"": [],
                        ""cmc_rank"": 60,
                        ""last_updated"": ""2018-12-03T04:16:04.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.19729535301214696,
                                ""volume_24h"": 772451.0870611833,
                                ""percent_change_1h"": -0.0175,
                                ""percent_change_24h"": -9.3119,
                                ""percent_change_7d"": -11.3425,
                                ""market_cap"": 89286487.88203856,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1759,
                        ""name"": ""Status"",
                        ""symbol"": ""SNT"",
                        ""slug"": ""status"",
                        ""circulating_supply"": 3470483788,
                        ""total_supply"": 6804870174,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-28T00:00:00.000Z"",
                        ""num_market_pairs"": 76,
                        ""tags"": [],
                        ""cmc_rank"": 61,
                        ""last_updated"": ""2018-12-03T04:16:10.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.025582296749110868,
                                ""volume_24h"": 2251857.475720193,
                                ""percent_change_1h"": 0.3145,
                                ""percent_change_24h"": -4.57,
                                ""percent_change_7d"": 2,
                                ""market_cap"": 88782946.12759438,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2027,
                        ""name"": ""Cryptonex"",
                        ""symbol"": ""CNX"",
                        ""slug"": ""cryptonex"",
                        ""circulating_supply"": 55576246.9553227,
                        ""total_supply"": 107024971.915323,
                        ""max_supply"": 210000000,
                        ""date_added"": ""2017-10-07T00:00:00.000Z"",
                        ""num_market_pairs"": 21,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 62,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.5799152864315646,
                                ""volume_24h"": 8145252.124154592,
                                ""percent_change_1h"": -0.1658,
                                ""percent_change_24h"": -5.7294,
                                ""percent_change_7d"": -1.9673,
                                ""market_cap"": 87805762.12721004,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1966,
                        ""name"": ""Decentraland"",
                        ""symbol"": ""MANA"",
                        ""slug"": ""decentraland"",
                        ""circulating_supply"": 1050141509.426,
                        ""total_supply"": 2644403343.1583,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-17T00:00:00.000Z"",
                        ""num_market_pairs"": 49,
                        ""tags"": [],
                        ""cmc_rank"": 63,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.08227231065046625,
                                ""volume_24h"": 4824940.632431372,
                                ""percent_change_1h"": 0.1563,
                                ""percent_change_24h"": -2.0858,
                                ""percent_change_7d"": 12.7426,
                                ""market_cap"": 86397568.4904454,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2135,
                        ""name"": ""Revain"",
                        ""symbol"": ""R"",
                        ""slug"": ""revain"",
                        ""circulating_supply"": 434450000,
                        ""total_supply"": 484450000,
                        ""max_supply"": 484450000,
                        ""date_added"": ""2017-11-01T00:00:00.000Z"",
                        ""num_market_pairs"": 16,
                        ""tags"": [],
                        ""cmc_rank"": 64,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.1943226731332954,
                                ""volume_24h"": 2369879.0880472846,
                                ""percent_change_1h"": -0.4355,
                                ""percent_change_24h"": -3.3397,
                                ""percent_change_7d"": -12.1055,
                                ""market_cap"": 84423485.34276019,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2308,
                        ""name"": ""Dai"",
                        ""symbol"": ""DAI"",
                        ""slug"": ""dai"",
                        ""circulating_supply"": 62588016.1417371,
                        ""total_supply"": 62588016.1417371,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-24T00:00:00.000Z"",
                        ""num_market_pairs"": 41,
                        ""tags"": [],
                        ""cmc_rank"": 65,
                        ""last_updated"": ""2018-12-03T04:15:18.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.3148591807482573,
                                ""volume_24h"": 5315421.5616071215,
                                ""percent_change_1h"": 0.1673,
                                ""percent_change_24h"": -0.4495,
                                ""percent_change_7d"": -1.1389,
                                ""market_cap"": 82294427.62878315,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2300,
                        ""name"": ""WAX"",
                        ""symbol"": ""WAX"",
                        ""slug"": ""wax"",
                        ""circulating_supply"": 935838056.302148,
                        ""total_supply"": 1850000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-21T00:00:00.000Z"",
                        ""num_market_pairs"": 27,
                        ""tags"": [],
                        ""cmc_rank"": 66,
                        ""last_updated"": ""2018-12-03T04:15:18.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.08564269380299769,
                                ""volume_24h"": 227249.1450311748,
                                ""percent_change_1h"": 0.2352,
                                ""percent_change_24h"": -3.8081,
                                ""percent_change_7d"": 5.2766,
                                ""market_cap"": 80147692.10507737,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1320,
                        ""name"": ""Ardor"",
                        ""symbol"": ""ARDR"",
                        ""slug"": ""ardor"",
                        ""circulating_supply"": 998999495,
                        ""total_supply"": 998999495,
                        ""max_supply"": 998999495,
                        ""date_added"": ""2016-07-23T00:00:00.000Z"",
                        ""num_market_pairs"": 15,
                        ""tags"": [],
                        ""cmc_rank"": 67,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.08012299451223967,
                                ""volume_24h"": 396736.9059588579,
                                ""percent_change_1h"": 0.3229,
                                ""percent_change_24h"": -6.7106,
                                ""percent_change_7d"": 2.1496,
                                ""market_cap"": 80042831.0556152,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2502,
                        ""name"": ""Huobi Token"",
                        ""symbol"": ""HT"",
                        ""slug"": ""huobi-token"",
                        ""circulating_supply"": 50000200,
                        ""total_supply"": 500000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-02-03T00:00:00.000Z"",
                        ""num_market_pairs"": 16,
                        ""tags"": [],
                        ""cmc_rank"": 68,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.5814577491279573,
                                ""volume_24h"": 23517018.426068097,
                                ""percent_change_1h"": 1.1279,
                                ""percent_change_24h"": -2.9527,
                                ""percent_change_7d"": 8.5212,
                                ""market_cap"": 79073203.7479477,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2694,
                        ""name"": ""Nexo"",
                        ""symbol"": ""NEXO"",
                        ""slug"": ""nexo"",
                        ""circulating_supply"": 560000011,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-05-01T00:00:00.000Z"",
                        ""num_market_pairs"": 14,
                        ""tags"": [],
                        ""cmc_rank"": 69,
                        ""last_updated"": ""2018-12-03T04:15:24.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.1367519169224997,
                                ""volume_24h"": 2459154.1398129216,
                                ""percent_change_1h"": 0.0794,
                                ""percent_change_24h"": -7.4296,
                                ""percent_change_7d"": 2.264,
                                ""market_cap"": 76581074.98087092,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2405,
                        ""name"": ""IOST"",
                        ""symbol"": ""IOST"",
                        ""slug"": ""iostoken"",
                        ""circulating_supply"": 12003807130.9,
                        ""total_supply"": 21000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-16T00:00:00.000Z"",
                        ""num_market_pairs"": 52,
                        ""tags"": [],
                        ""cmc_rank"": 70,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.006305376904532052,
                                ""volume_24h"": 5493255.651705601,
                                ""percent_change_1h"": 0.5362,
                                ""percent_change_24h"": -5.2984,
                                ""percent_change_7d"": 1.2208,
                                ""market_cap"": 75688528.24963401,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3515,
                        ""name"": ""DEX"",
                        ""symbol"": ""DEX"",
                        ""slug"": ""dex"",
                        ""circulating_supply"": 191542290.51,
                        ""total_supply"": 1892996914,
                        ""max_supply"": null,
                        ""date_added"": ""2018-10-29T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [],
                        ""cmc_rank"": 71,
                        ""last_updated"": ""2018-12-03T04:15:37.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3951258255614854,
                                ""volume_24h"": 188951.6126839305,
                                ""percent_change_1h"": -0.0007,
                                ""percent_change_24h"": -6.8609,
                                ""percent_change_7d"": -5.3802,
                                ""market_cap"": 75683305.6677016,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2608,
                        ""name"": ""Mithril"",
                        ""symbol"": ""MITH"",
                        ""slug"": ""mithril"",
                        ""circulating_supply"": 408362725.6597,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-24T00:00:00.000Z"",
                        ""num_market_pairs"": 33,
                        ""tags"": [],
                        ""cmc_rank"": 72,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.18353085934396107,
                                ""volume_24h"": 30714305.23711055,
                                ""percent_change_1h"": 10.5458,
                                ""percent_change_24h"": 29.0649,
                                ""percent_change_7d"": 21.6182,
                                ""market_cap"": 74947161.96436696,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1715,
                        ""name"": ""MobileGo"",
                        ""symbol"": ""MGO"",
                        ""slug"": ""mobilego"",
                        ""circulating_supply"": 99998615,
                        ""total_supply"": 99998615,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-11T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [],
                        ""cmc_rank"": 73,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.7167724240940322,
                                ""volume_24h"": 26014405.007428378,
                                ""percent_change_1h"": -0.1986,
                                ""percent_change_24h"": 9.0145,
                                ""percent_change_7d"": 22.8405,
                                ""market_cap"": 71676249.67959586,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2087,
                        ""name"": ""KuCoin Shares"",
                        ""symbol"": ""KCS"",
                        ""slug"": ""kucoin-shares"",
                        ""circulating_supply"": 90138154,
                        ""total_supply"": 180138154,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-24T00:00:00.000Z"",
                        ""num_market_pairs"": 8,
                        ""tags"": [],
                        ""cmc_rank"": 74,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.7811065361966504,
                                ""volume_24h"": 37661.23957685649,
                                ""percent_change_1h"": -0.2493,
                                ""percent_change_24h"": -5.0868,
                                ""percent_change_7d"": -1.8824,
                                ""market_cap"": 70407501.25010026,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1703,
                        ""name"": ""Metaverse ETP"",
                        ""symbol"": ""ETP"",
                        ""slug"": ""metaverse"",
                        ""circulating_supply"": 53696511.4138519,
                        ""total_supply"": 57020644.7597519,
                        ""max_supply"": 100000000,
                        ""date_added"": ""2017-06-05T00:00:00.000Z"",
                        ""num_market_pairs"": 25,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 75,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.2658505314007382,
                                ""volume_24h"": 2766276.722746777,
                                ""percent_change_1h"": 0.0372,
                                ""percent_change_24h"": -4.8093,
                                ""percent_change_7d"": -5.7724,
                                ""market_cap"": 67971757.50759023,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2631,
                        ""name"": ""ODEM"",
                        ""symbol"": ""ODE"",
                        ""slug"": ""odem"",
                        ""circulating_supply"": 218002385.832452,
                        ""total_supply"": 268946131,
                        ""max_supply"": null,
                        ""date_added"": ""2018-04-10T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [],
                        ""cmc_rank"": 76,
                        ""last_updated"": ""2018-12-03T04:15:25.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.29818164344016257,
                                ""volume_24h"": 1104267.6915497184,
                                ""percent_change_1h"": 0.0891,
                                ""percent_change_24h"": -0.1301,
                                ""percent_change_7d"": -3.8485,
                                ""market_cap"": 65004309.681396954,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3116,
                        ""name"": ""Insight Chain"",
                        ""symbol"": ""INB"",
                        ""slug"": ""insight-chain"",
                        ""circulating_supply"": 169343326.202003,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-08-08T00:00:00.000Z"",
                        ""num_market_pairs"": 2,
                        ""tags"": [],
                        ""cmc_rank"": 77,
                        ""last_updated"": ""2018-12-03T04:15:29.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3772134015938299,
                                ""volume_24h"": 2914327.445446097,
                                ""percent_change_1h"": -0.3883,
                                ""percent_change_24h"": -1.6291,
                                ""percent_change_7d"": 0.5487,
                                ""market_cap"": 63878572.1138711,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1925,
                        ""name"": ""Waltonchain"",
                        ""symbol"": ""WTC"",
                        ""slug"": ""waltonchain"",
                        ""circulating_supply"": 40354159.4106683,
                        ""total_supply"": 70000000,
                        ""max_supply"": 100000000,
                        ""date_added"": ""2017-08-27T00:00:00.000Z"",
                        ""num_market_pairs"": 27,
                        ""tags"": [],
                        ""cmc_rank"": 78,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.5589341914845072,
                                ""volume_24h"": 7040959.39769959,
                                ""percent_change_1h"": -0.4116,
                                ""percent_change_24h"": -5.3447,
                                ""percent_change_7d"": 1.3118,
                                ""market_cap"": 62909478.873907104,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2585,
                        ""name"": ""Centrality"",
                        ""symbol"": ""CENNZ"",
                        ""slug"": ""centrality"",
                        ""circulating_supply"": 801382336.219112,
                        ""total_supply"": 1200000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-13T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [],
                        ""cmc_rank"": 79,
                        ""last_updated"": ""2018-12-03T04:15:23.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.07730668097392131,
                                ""volume_24h"": 273654.9299242274,
                                ""percent_change_1h"": 2.0892,
                                ""percent_change_24h"": 6.4291,
                                ""percent_change_7d"": 46.3838,
                                ""market_cap"": 61952208.604226634,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2403,
                        ""name"": ""MOAC"",
                        ""symbol"": ""MOAC"",
                        ""slug"": ""moac"",
                        ""circulating_supply"": 62463333.6041915,
                        ""total_supply"": 151205864,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-15T00:00:00.000Z"",
                        ""num_market_pairs"": 2,
                        ""tags"": [],
                        ""cmc_rank"": 80,
                        ""last_updated"": ""2018-12-03T04:15:18.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9880174011745582,
                                ""volume_24h"": 24614.552209534377,
                                ""percent_change_1h"": 0.8584,
                                ""percent_change_24h"": -7.6089,
                                ""percent_change_7d"": -0.7826,
                                ""market_cap"": 61714860.53631273,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3306,
                        ""name"": ""Gemini Dollar"",
                        ""symbol"": ""GUSD"",
                        ""slug"": ""gemini-dollar"",
                        ""circulating_supply"": 44776968.43,
                        ""total_supply"": 44776968.43,
                        ""max_supply"": null,
                        ""date_added"": ""2018-10-05T00:00:00.000Z"",
                        ""num_market_pairs"": 40,
                        ""tags"": [],
                        ""cmc_rank"": 81,
                        ""last_updated"": ""2018-12-03T04:15:35.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.3405299731243978,
                                ""volume_24h"": 1891005.4488276616,
                                ""percent_change_1h"": 0.1351,
                                ""percent_change_24h"": -0.1326,
                                ""percent_change_7d"": 1.4777,
                                ""market_cap"": 60024868.28605991,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2416,
                        ""name"": ""Theta Token"",
                        ""symbol"": ""THETA"",
                        ""slug"": ""theta-token"",
                        ""circulating_supply"": 706502689,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-17T00:00:00.000Z"",
                        ""num_market_pairs"": 20,
                        ""tags"": [],
                        ""cmc_rank"": 82,
                        ""last_updated"": ""2018-12-03T04:15:18.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.08437212735006752,
                                ""volume_24h"": 9151097.700177196,
                                ""percent_change_1h"": 0.5444,
                                ""percent_change_24h"": -19.3825,
                                ""percent_change_7d"": 16.3623,
                                ""market_cap"": 59609134.84947314,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2575,
                        ""name"": ""Bitcoin Private"",
                        ""symbol"": ""BTCP"",
                        ""slug"": ""bitcoin-private"",
                        ""circulating_supply"": 20524490.1089687,
                        ""total_supply"": 20524490.1089687,
                        ""max_supply"": 21000000,
                        ""date_added"": ""2018-03-10T00:00:00.000Z"",
                        ""num_market_pairs"": 20,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 83,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 2.863713678527561,
                                ""volume_24h"": 215786.61510344755,
                                ""percent_change_1h"": -0.6488,
                                ""percent_change_24h"": -17.6764,
                                ""percent_change_7d"": 35.9987,
                                ""market_cap"": 58776263.06985731,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2606,
                        ""name"": ""Wanchain"",
                        ""symbol"": ""WAN"",
                        ""slug"": ""wanchain"",
                        ""circulating_supply"": 106152492.636,
                        ""total_supply"": 210000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-23T00:00:00.000Z"",
                        ""num_market_pairs"": 13,
                        ""tags"": [],
                        ""cmc_rank"": 84,
                        ""last_updated"": ""2018-12-03T04:15:21.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.5445445814718088,
                                ""volume_24h"": 2234935.5418180116,
                                ""percent_change_1h"": 0.7427,
                                ""percent_change_24h"": -8.3494,
                                ""percent_change_7d"": 3.4763,
                                ""market_cap"": 57804764.67465989,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1750,
                        ""name"": ""GXChain"",
                        ""symbol"": ""GXS"",
                        ""slug"": ""gxchain"",
                        ""circulating_supply"": 60000000,
                        ""total_supply"": 100000000,
                        ""max_supply"": 100000000,
                        ""date_added"": ""2017-06-25T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [],
                        ""cmc_rank"": 85,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9437551163279403,
                                ""volume_24h"": 15472924.846242554,
                                ""percent_change_1h"": 0.315,
                                ""percent_change_24h"": -5.1201,
                                ""percent_change_7d"": 0.6281,
                                ""market_cap"": 56625306.97967642,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2492,
                        ""name"": ""Elastos"",
                        ""symbol"": ""ELA"",
                        ""slug"": ""elastos"",
                        ""circulating_supply"": 14111943.576284,
                        ""total_supply"": 33849205.314507,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-31T00:00:00.000Z"",
                        ""num_market_pairs"": 14,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 86,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 4.00745603147437,
                                ""volume_24h"": 1547216.8389038169,
                                ""percent_change_1h"": 0.046,
                                ""percent_change_24h"": -6.806,
                                ""percent_change_7d"": 3.225,
                                ""market_cap"": 56552993.400605306,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2577,
                        ""name"": ""Ravencoin"",
                        ""symbol"": ""RVN"",
                        ""slug"": ""ravencoin"",
                        ""circulating_supply"": 2374325000,
                        ""total_supply"": 2374325000,
                        ""max_supply"": 21000000000,
                        ""date_added"": ""2018-03-10T00:00:00.000Z"",
                        ""num_market_pairs"": 27,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 87,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.02365918755706003,
                                ""volume_24h"": 4483985.202944794,
                                ""percent_change_1h"": 0.7456,
                                ""percent_change_24h"": -11.305,
                                ""percent_change_7d"": -4.5259,
                                ""market_cap"": 56174600.49641656,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1586,
                        ""name"": ""Ark"",
                        ""symbol"": ""ARK"",
                        ""slug"": ""ark"",
                        ""circulating_supply"": 106768144,
                        ""total_supply"": 138018144,
                        ""max_supply"": null,
                        ""date_added"": ""2017-03-22T00:00:00.000Z"",
                        ""num_market_pairs"": 20,
                        ""tags"": [],
                        ""cmc_rank"": 88,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.5243718231203848,
                                ""volume_24h"": 307032.4778757304,
                                ""percent_change_1h"": -0.4185,
                                ""percent_change_24h"": -6.4528,
                                ""percent_change_7d"": -1.1821,
                                ""market_cap"": 55986206.32045977,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 213,
                        ""name"": ""MonaCoin"",
                        ""symbol"": ""MONA"",
                        ""slug"": ""monacoin"",
                        ""circulating_supply"": 64086849.8711679,
                        ""total_supply"": 64086849.8711679,
                        ""max_supply"": null,
                        ""date_added"": ""2014-03-20T00:00:00.000Z"",
                        ""num_market_pairs"": 20,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 89,
                        ""last_updated"": ""2018-12-03T04:16:04.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.8663777182985852,
                                ""volume_24h"": 1151329.3462641118,
                                ""percent_change_1h"": -1.0568,
                                ""percent_change_24h"": -4.7035,
                                ""percent_change_7d"": -19.9269,
                                ""market_cap"": 55523418.76432642,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 118,
                        ""name"": ""ReddCoin"",
                        ""symbol"": ""RDD"",
                        ""slug"": ""reddcoin"",
                        ""circulating_supply"": 28808713173.7887,
                        ""total_supply"": 28808713173.7887,
                        ""max_supply"": null,
                        ""date_added"": ""2014-02-10T00:00:00.000Z"",
                        ""num_market_pairs"": 24,
                        ""tags"": [],
                        ""cmc_rank"": 90,
                        ""last_updated"": ""2018-12-03T04:16:02.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0019120341590099078,
                                ""volume_24h"": 400601.077575156,
                                ""percent_change_1h"": -1.9258,
                                ""percent_change_24h"": -4.9008,
                                ""percent_change_7d"": 9.1089,
                                ""market_cap"": 55083243.66540273,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1169,
                        ""name"": ""PIVX"",
                        ""symbol"": ""PIVX"",
                        ""slug"": ""pivx"",
                        ""circulating_supply"": 56781165.992094,
                        ""total_supply"": 56781165.992094,
                        ""max_supply"": null,
                        ""date_added"": ""2016-02-13T00:00:00.000Z"",
                        ""num_market_pairs"": 27,
                        ""tags"": [],
                        ""cmc_rank"": 91,
                        ""last_updated"": ""2018-12-03T04:16:07.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9596276089269795,
                                ""volume_24h"": 306694.4047399458,
                                ""percent_change_1h"": -0.295,
                                ""percent_change_24h"": -3.9458,
                                ""percent_change_7d"": 0.6111,
                                ""market_cap"": 54488774.55307908,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2062,
                        ""name"": ""Aion"",
                        ""symbol"": ""AION"",
                        ""slug"": ""aion"",
                        ""circulating_supply"": 262673279.197718,
                        ""total_supply"": 465934586.66,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-18T00:00:00.000Z"",
                        ""num_market_pairs"": 27,
                        ""tags"": [],
                        ""cmc_rank"": 92,
                        ""last_updated"": ""2018-12-03T04:15:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.2032840718031134,
                                ""volume_24h"": 2144569.6147353505,
                                ""percent_change_1h"": 0.21,
                                ""percent_change_24h"": -7.1754,
                                ""percent_change_7d"": 13.516,
                                ""market_cap"": 53397293.749188155,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1727,
                        ""name"": ""Bancor"",
                        ""symbol"": ""BNT"",
                        ""slug"": ""bancor"",
                        ""circulating_supply"": 58427052.9462718,
                        ""total_supply"": 77594790.0335988,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-18T00:00:00.000Z"",
                        ""num_market_pairs"": 125,
                        ""tags"": [],
                        ""cmc_rank"": 93,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.8956342173627685,
                                ""volume_24h"": 1821159.7236029955,
                                ""percent_change_1h"": 0.0457,
                                ""percent_change_24h"": -3.5636,
                                ""percent_change_7d"": -0.5644,
                                ""market_cap"": 52329267.83834718,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2496,
                        ""name"": ""Polymath"",
                        ""symbol"": ""POLY"",
                        ""slug"": ""polymath-network"",
                        ""circulating_supply"": 286787106.860699,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-02-02T00:00:00.000Z"",
                        ""num_market_pairs"": 32,
                        ""tags"": [],
                        ""cmc_rank"": 94,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.1799578696245597,
                                ""volume_24h"": 4126582.8110801773,
                                ""percent_change_1h"": 0.1882,
                                ""percent_change_24h"": -3.5889,
                                ""percent_change_7d"": -0.3209,
                                ""market_cap"": 51609596.78644234,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1903,
                        ""name"": ""HyperCash"",
                        ""symbol"": ""HC"",
                        ""slug"": ""hypercash"",
                        ""circulating_supply"": 43529780.865052,
                        ""total_supply"": 43529780.865052,
                        ""max_supply"": 84000000,
                        ""date_added"": ""2017-08-20T00:00:00.000Z"",
                        ""num_market_pairs"": 19,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 95,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.1771932551893738,
                                ""volume_24h"": 72081004.59688438,
                                ""percent_change_1h"": -0.589,
                                ""percent_change_24h"": -4.9661,
                                ""percent_change_7d"": -2.6204,
                                ""market_cap"": 51242964.43421067,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2313,
                        ""name"": ""SIRIN LABS Token"",
                        ""symbol"": ""SRN"",
                        ""slug"": ""sirin-labs-token"",
                        ""circulating_supply"": 491820906.379,
                        ""total_supply"": 572166103.886,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-28T00:00:00.000Z"",
                        ""num_market_pairs"": 27,
                        ""tags"": [],
                        ""cmc_rank"": 96,
                        ""last_updated"": ""2018-12-03T04:15:19.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.10197082568169027,
                                ""volume_24h"": 1662782.8495190868,
                                ""percent_change_1h"": -0.7947,
                                ""percent_change_24h"": -6.702,
                                ""percent_change_7d"": -36.3299,
                                ""market_cap"": 50151383.91098392,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2299,
                        ""name"": ""aelf"",
                        ""symbol"": ""ELF"",
                        ""slug"": ""aelf"",
                        ""circulating_supply"": 280000000,
                        ""total_supply"": 300000000,
                        ""max_supply"": 1000000000,
                        ""date_added"": ""2017-12-21T00:00:00.000Z"",
                        ""num_market_pairs"": 47,
                        ""tags"": [],
                        ""cmc_rank"": 97,
                        ""last_updated"": ""2018-12-03T04:15:17.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.17838016417019326,
                                ""volume_24h"": 7555284.186564048,
                                ""percent_change_1h"": 0.6387,
                                ""percent_change_24h"": -1.9088,
                                ""percent_change_7d"": 14.6812,
                                ""market_cap"": 49946445.96765412,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1776,
                        ""name"": ""Crypto.com"",
                        ""symbol"": ""MCO"",
                        ""slug"": ""crypto-com"",
                        ""circulating_supply"": 15793831.0949625,
                        ""total_supply"": 31587682.3632061,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-03T00:00:00.000Z"",
                        ""num_market_pairs"": 43,
                        ""tags"": [],
                        ""cmc_rank"": 98,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 3.1229153835839245,
                                ""volume_24h"": 7083776.696028631,
                                ""percent_change_1h"": -0.0032,
                                ""percent_change_24h"": -2.0289,
                                ""percent_change_7d"": 5.3959,
                                ""market_cap"": 49322798.09218452,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1414,
                        ""name"": ""Zcoin"",
                        ""symbol"": ""XZC"",
                        ""slug"": ""zcoin"",
                        ""circulating_supply"": 5757840.97134081,
                        ""total_supply"": 5757840.97134081,
                        ""max_supply"": 21400000,
                        ""date_added"": ""2016-10-06T00:00:00.000Z"",
                        ""num_market_pairs"": 22,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 99,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 8.548591348866083,
                                ""volume_24h"": 5199137.746682128,
                                ""percent_change_1h"": -0.8439,
                                ""percent_change_24h"": 4.847,
                                ""percent_change_7d"": 16.0801,
                                ""market_cap"": 49221429.51575072,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1229,
                        ""name"": ""DigixDAO"",
                        ""symbol"": ""DGD"",
                        ""slug"": ""digixdao"",
                        ""circulating_supply"": 2000000,
                        ""total_supply"": 2000000,
                        ""max_supply"": null,
                        ""date_added"": ""2016-04-18T00:00:00.000Z"",
                        ""num_market_pairs"": 23,
                        ""tags"": [],
                        ""cmc_rank"": 100,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 23.514196871761886,
                                ""volume_24h"": 391422.7732569418,
                                ""percent_change_1h"": -0.1546,
                                ""percent_change_24h"": -10.6686,
                                ""percent_change_7d"": -1.0464,
                                ""market_cap"": 47028393.74352378,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2840,
                        ""name"": ""QuarkChain"",
                        ""symbol"": ""QKC"",
                        ""slug"": ""quarkchain"",
                        ""circulating_supply"": 801649918.691442,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-06-04T00:00:00.000Z"",
                        ""num_market_pairs"": 23,
                        ""tags"": [],
                        ""cmc_rank"": 101,
                        ""last_updated"": ""2018-12-03T04:15:25.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.058527152978001276,
                                ""volume_24h"": 4469694.692141748,
                                ""percent_change_1h"": 0.4108,
                                ""percent_change_24h"": -5.2065,
                                ""percent_change_7d"": -10.5649,
                                ""market_cap"": 46918287.42605631,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3178,
                        ""name"": ""Linkey"",
                        ""symbol"": ""LKY"",
                        ""slug"": ""linkey"",
                        ""circulating_supply"": 50000000,
                        ""total_supply"": 195000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-08-16T00:00:00.000Z"",
                        ""num_market_pairs"": 1,
                        ""tags"": [],
                        ""cmc_rank"": 102,
                        ""last_updated"": ""2018-12-03T04:15:34.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9266518585732268,
                                ""volume_24h"": 92785.65059887987,
                                ""percent_change_1h"": 0.2027,
                                ""percent_change_24h"": -2.6365,
                                ""percent_change_7d"": 6.5477,
                                ""market_cap"": 46332592.92866135,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 66,
                        ""name"": ""Nxt"",
                        ""symbol"": ""NXT"",
                        ""slug"": ""nxt"",
                        ""circulating_supply"": 998999941.507691,
                        ""total_supply"": 998999941.507691,
                        ""max_supply"": 1000000000,
                        ""date_added"": ""2013-12-04T00:00:00.000Z"",
                        ""num_market_pairs"": 25,
                        ""tags"": [],
                        ""cmc_rank"": 103,
                        ""last_updated"": ""2018-12-03T04:16:02.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.046057016785357834,
                                ""volume_24h"": 683348.3830876917,
                                ""percent_change_1h"": -0.3219,
                                ""percent_change_24h"": -7.2234,
                                ""percent_change_7d"": 10.7755,
                                ""market_cap"": 46010957.07459122,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2349,
                        ""name"": ""Mixin"",
                        ""symbol"": ""XIN"",
                        ""slug"": ""mixin"",
                        ""circulating_supply"": 444635.401147836,
                        ""total_supply"": 1000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-09T00:00:00.000Z"",
                        ""num_market_pairs"": 3,
                        ""tags"": [],
                        ""cmc_rank"": 104,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 103.36843591265985,
                                ""volume_24h"": 17356.83195139277,
                                ""percent_change_1h"": 0.1381,
                                ""percent_change_24h"": -4.2454,
                                ""percent_change_7d"": -12.1667,
                                ""market_cap"": 45961265.96804989,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2132,
                        ""name"": ""Power Ledger"",
                        ""symbol"": ""POWR"",
                        ""slug"": ""power-ledger"",
                        ""circulating_supply"": 390595382.427506,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-11-01T00:00:00.000Z"",
                        ""num_market_pairs"": 35,
                        ""tags"": [],
                        ""cmc_rank"": 105,
                        ""last_updated"": ""2018-12-03T04:15:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.11633996962353295,
                                ""volume_24h"": 3958175.558265427,
                                ""percent_change_1h"": 1.0928,
                                ""percent_change_24h"": -1.4428,
                                ""percent_change_7d"": 9.8189,
                                ""market_cap"": 45441854.92670829,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1934,
                        ""name"": ""Loopring"",
                        ""symbol"": ""LRC"",
                        ""slug"": ""loopring"",
                        ""circulating_supply"": 788984490.938568,
                        ""total_supply"": 1374955751.72106,
                        ""max_supply"": null,
                        ""date_added"": ""2017-08-30T00:00:00.000Z"",
                        ""num_market_pairs"": 32,
                        ""tags"": [],
                        ""cmc_rank"": 106,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.05743596114857538,
                                ""volume_24h"": 473339.43798994244,
                                ""percent_change_1h"": 0.6291,
                                ""percent_change_24h"": -7.7618,
                                ""percent_change_7d"": 0.2546,
                                ""market_cap"": 45316082.56837612,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1876,
                        ""name"": ""Dentacoin"",
                        ""symbol"": ""DCN"",
                        ""slug"": ""dentacoin"",
                        ""circulating_supply"": 325226613094,
                        ""total_supply"": 1963173416170,
                        ""max_supply"": 8000000000000,
                        ""date_added"": ""2017-08-11T00:00:00.000Z"",
                        ""num_market_pairs"": 13,
                        ""tags"": [],
                        ""cmc_rank"": 107,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.00013824700914689633,
                                ""volume_24h"": 6735.821427129018,
                                ""percent_change_1h"": 0.2349,
                                ""percent_change_24h"": -2.0784,
                                ""percent_change_7d"": -2.9142,
                                ""market_cap"": 44961606.55522033,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1908,
                        ""name"": ""Nebulas"",
                        ""symbol"": ""NAS"",
                        ""slug"": ""nebulas-token"",
                        ""circulating_supply"": 45500000,
                        ""total_supply"": 100000000,
                        ""max_supply"": 100000000,
                        ""date_added"": ""2017-08-23T00:00:00.000Z"",
                        ""num_market_pairs"": 17,
                        ""tags"": [],
                        ""cmc_rank"": 108,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9852248399451216,
                                ""volume_24h"": 8807847.219528751,
                                ""percent_change_1h"": 0.8152,
                                ""percent_change_24h"": -6.95,
                                ""percent_change_7d"": 7.6302,
                                ""market_cap"": 44827730.217503026,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1698,
                        ""name"": ""Horizen"",
                        ""symbol"": ""ZEN"",
                        ""slug"": ""zencash"",
                        ""circulating_supply"": 5284875,
                        ""total_supply"": 5284875,
                        ""max_supply"": 21000000,
                        ""date_added"": ""2017-06-01T00:00:00.000Z"",
                        ""num_market_pairs"": 29,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 109,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 8.467868501151536,
                                ""volume_24h"": 881177.2695041703,
                                ""percent_change_1h"": -0.9385,
                                ""percent_change_24h"": -8.302,
                                ""percent_change_7d"": -4.1471,
                                ""market_cap"": 44751626.545023225,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1710,
                        ""name"": ""Veritaseum"",
                        ""symbol"": ""VERI"",
                        ""slug"": ""veritaseum"",
                        ""circulating_supply"": 2036645.44,
                        ""total_supply"": 100000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-08T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [],
                        ""cmc_rank"": 110,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 21.801072728074196,
                                ""volume_24h"": 609295.707118703,
                                ""percent_change_1h"": -0.3572,
                                ""percent_change_24h"": -7.1293,
                                ""percent_change_7d"": -8.6362,
                                ""market_cap"": 44401055.35874067,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2772,
                        ""name"": ""Digitex Futures"",
                        ""symbol"": ""DGTX"",
                        ""slug"": ""digitex-futures"",
                        ""circulating_supply"": 731250000,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-05-23T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 111,
                        ""last_updated"": ""2018-12-03T04:15:26.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.059556408133335965,
                                ""volume_24h"": 400997.02954793593,
                                ""percent_change_1h"": -1.1042,
                                ""percent_change_24h"": -2.6704,
                                ""percent_change_7d"": 2.3461,
                                ""market_cap"": 43550623.44750193,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2246,
                        ""name"": ""CyberMiles"",
                        ""symbol"": ""CMT"",
                        ""slug"": ""cybermiles"",
                        ""circulating_supply"": 764598428.5674,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-06T00:00:00.000Z"",
                        ""num_market_pairs"": 30,
                        ""tags"": [],
                        ""cmc_rank"": 112,
                        ""last_updated"": ""2018-12-03T04:15:17.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.05613814072908561,
                                ""volume_24h"": 2550410.29017479,
                                ""percent_change_1h"": 1.3012,
                                ""percent_change_24h"": -11.9402,
                                ""percent_change_7d"": -6.1857,
                                ""market_cap"": 42923134.18415441,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2588,
                        ""name"": ""Loom Network"",
                        ""symbol"": ""LOOM"",
                        ""slug"": ""loom-network"",
                        ""circulating_supply"": 605305734.315634,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-14T00:00:00.000Z"",
                        ""num_market_pairs"": 34,
                        ""tags"": [],
                        ""cmc_rank"": 113,
                        ""last_updated"": ""2018-12-03T04:15:21.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.07084614449738073,
                                ""volume_24h"": 2128696.7529639085,
                                ""percent_change_1h"": 0.3335,
                                ""percent_change_24h"": -8.0354,
                                ""percent_change_7d"": 10.5931,
                                ""market_cap"": 42883577.518418565,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1758,
                        ""name"": ""TenX"",
                        ""symbol"": ""PAY"",
                        ""slug"": ""tenx"",
                        ""circulating_supply"": 109347860.533775,
                        ""total_supply"": 205218255.948578,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-27T00:00:00.000Z"",
                        ""num_market_pairs"": 35,
                        ""tags"": [],
                        ""cmc_rank"": 114,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.36632206783098686,
                                ""volume_24h"": 299264.3069720836,
                                ""percent_change_1h"": -0.5897,
                                ""percent_change_24h"": -4.9298,
                                ""percent_change_7d"": 1.2822,
                                ""market_cap"": 40056534.38362682,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2471,
                        ""name"": ""Smartlands"",
                        ""symbol"": ""SLT"",
                        ""slug"": ""smartlands"",
                        ""circulating_supply"": 5100895.65,
                        ""total_supply"": 7186785.07945,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-25T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [],
                        ""cmc_rank"": 115,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 7.834964479140572,
                                ""volume_24h"": 795881.962751863,
                                ""percent_change_1h"": 0.1709,
                                ""percent_change_24h"": -4.6413,
                                ""percent_change_7d"": 11.01,
                                ""market_cap"": 39965336.229552664,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3126,
                        ""name"": ""ProximaX"",
                        ""symbol"": ""XPX"",
                        ""slug"": ""proximax"",
                        ""circulating_supply"": 6097456550,
                        ""total_supply"": 9000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-08-08T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 116,
                        ""last_updated"": ""2018-12-03T04:15:30.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.006364283324614589,
                                ""volume_24h"": 2555382.2588673625,
                                ""percent_change_1h"": -0.3818,
                                ""percent_change_24h"": -6.3179,
                                ""percent_change_7d"": -9.2554,
                                ""market_cap"": 38805941.043726996,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2095,
                        ""name"": ""BOScoin"",
                        ""symbol"": ""BOS"",
                        ""slug"": ""boscoin"",
                        ""circulating_supply"": 456838751.096096,
                        ""total_supply"": 500000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-26T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 117,
                        ""last_updated"": ""2018-12-03T04:15:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.08382950765763919,
                                ""volume_24h"": 12530.01116056925,
                                ""percent_change_1h"": -0.1508,
                                ""percent_change_24h"": -10.7474,
                                ""percent_change_7d"": -14.7826,
                                ""market_cap"": 38296567.5833165,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2591,
                        ""name"": ""Dropil"",
                        ""symbol"": ""DROP"",
                        ""slug"": ""dropil"",
                        ""circulating_supply"": 21509034202.3575,
                        ""total_supply"": 30000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-18T00:00:00.000Z"",
                        ""num_market_pairs"": 7,
                        ""tags"": [],
                        ""cmc_rank"": 118,
                        ""last_updated"": ""2018-12-03T04:15:24.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0017559417385482389,
                                ""volume_24h"": 540087.3118101936,
                                ""percent_change_1h"": 1.3639,
                                ""percent_change_24h"": -6.133,
                                ""percent_change_7d"": -4.9971,
                                ""market_cap"": 37768610.91178116,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3200,
                        ""name"": ""Nasdacoin"",
                        ""symbol"": ""NSD"",
                        ""slug"": ""nasdacoin"",
                        ""circulating_supply"": 18794086.3558151,
                        ""total_supply"": 18794086.3558151,
                        ""max_supply"": 84000000,
                        ""date_added"": ""2018-08-22T00:00:00.000Z"",
                        ""num_market_pairs"": 7,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 119,
                        ""last_updated"": ""2018-12-03T04:15:35.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.9469950467153578,
                                ""volume_24h"": 84198.16770393045,
                                ""percent_change_1h"": -0.5274,
                                ""percent_change_24h"": -7.3869,
                                ""percent_change_7d"": 11.4862,
                                ""market_cap"": 36591993.0423127,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2835,
                        ""name"": ""Endor Protocol"",
                        ""symbol"": ""EDR"",
                        ""slug"": ""endor-protocol"",
                        ""circulating_supply"": 685685057.569839,
                        ""total_supply"": 1469214244.88784,
                        ""max_supply"": null,
                        ""date_added"": ""2018-05-31T00:00:00.000Z"",
                        ""num_market_pairs"": 14,
                        ""tags"": [],
                        ""cmc_rank"": 120,
                        ""last_updated"": ""2018-12-03T04:15:26.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.05325548836157606,
                                ""volume_24h"": 566058.4150072777,
                                ""percent_change_1h"": -0.1682,
                                ""percent_change_24h"": 3.4518,
                                ""percent_change_7d"": 31.9878,
                                ""market_cap"": 36516492.60311717,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1757,
                        ""name"": ""FunFair"",
                        ""symbol"": ""FUN"",
                        ""slug"": ""funfair"",
                        ""circulating_supply"": 5365813788.66342,
                        ""total_supply"": 10999873621.398,
                        ""max_supply"": null,
                        ""date_added"": ""2017-06-27T00:00:00.000Z"",
                        ""num_market_pairs"": 25,
                        ""tags"": [],
                        ""cmc_rank"": 121,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.006497579308077264,
                                ""volume_24h"": 1173187.5684490425,
                                ""percent_change_1h"": 0.0847,
                                ""percent_change_24h"": -7.6409,
                                ""percent_change_7d"": 1.2263,
                                ""market_cap"": 34864800.6442151,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2424,
                        ""name"": ""SingularityNET"",
                        ""symbol"": ""AGI"",
                        ""slug"": ""singularitynet"",
                        ""circulating_supply"": 539673260.161062,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-18T00:00:00.000Z"",
                        ""num_market_pairs"": 15,
                        ""tags"": [],
                        ""cmc_rank"": 122,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.06239703107366046,
                                ""volume_24h"": 1755467.2515459503,
                                ""percent_change_1h"": 6.5732,
                                ""percent_change_24h"": 13.6353,
                                ""percent_change_7d"": 27.7374,
                                ""market_cap"": 33674009.183893435,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2243,
                        ""name"": ""Dragonchain"",
                        ""symbol"": ""DRGN"",
                        ""slug"": ""dragonchain"",
                        ""circulating_supply"": 238421940,
                        ""total_supply"": 433494437,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-03T00:00:00.000Z"",
                        ""num_market_pairs"": 17,
                        ""tags"": [],
                        ""cmc_rank"": 123,
                        ""last_updated"": ""2018-12-03T04:15:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.14060974657754355,
                                ""volume_24h"": 1235572.8132310368,
                                ""percent_change_1h"": 0.2789,
                                ""percent_change_24h"": -9.8842,
                                ""percent_change_7d"": -1.5268,
                                ""market_cap"": 33524448.561926294,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2346,
                        ""name"": ""WaykiChain"",
                        ""symbol"": ""WICC"",
                        ""slug"": ""waykichain"",
                        ""circulating_supply"": 210000000,
                        ""total_supply"": 210000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-09T00:00:00.000Z"",
                        ""num_market_pairs"": 15,
                        ""tags"": [],
                        ""cmc_rank"": 124,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.1552364318291869,
                                ""volume_24h"": 2645189.6236708956,
                                ""percent_change_1h"": -0.9093,
                                ""percent_change_24h"": -5.0641,
                                ""percent_change_7d"": -2.243,
                                ""market_cap"": 32599650.68412925,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1772,
                        ""name"": ""Storj"",
                        ""symbol"": ""STORJ"",
                        ""slug"": ""storj"",
                        ""circulating_supply"": 135787438.700013,
                        ""total_supply"": 424999998.000013,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-02T00:00:00.000Z"",
                        ""num_market_pairs"": 31,
                        ""tags"": [],
                        ""cmc_rank"": 125,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.2393788975584978,
                                ""volume_24h"": 1512772.5872321348,
                                ""percent_change_1h"": -0.0413,
                                ""percent_change_24h"": -3.3495,
                                ""percent_change_7d"": 20.8134,
                                ""market_cap"": 32504647.378301214,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1982,
                        ""name"": ""Kyber Network"",
                        ""symbol"": ""KNC"",
                        ""slug"": ""kyber-network"",
                        ""circulating_supply"": 134132696.93,
                        ""total_supply"": 215625348.84,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-24T00:00:00.000Z"",
                        ""num_market_pairs"": 56,
                        ""tags"": [],
                        ""cmc_rank"": 126,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.2398493825260981,
                                ""volume_24h"": 68550254.78568104,
                                ""percent_change_1h"": -2.7531,
                                ""percent_change_24h"": -10.4062,
                                ""percent_change_7d"": 9.2043,
                                ""market_cap"": 32171644.535220757,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1785,
                        ""name"": ""Gas"",
                        ""symbol"": ""GAS"",
                        ""slug"": ""gas"",
                        ""circulating_supply"": 10128375.105773,
                        ""total_supply"": 17190378,
                        ""max_supply"": 100000000,
                        ""date_added"": ""2017-07-06T00:00:00.000Z"",
                        ""num_market_pairs"": 37,
                        ""tags"": [],
                        ""cmc_rank"": 127,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 3.152821662675015,
                                ""volume_24h"": 512315.93806126446,
                                ""percent_change_1h"": 0.2366,
                                ""percent_change_24h"": -7,
                                ""percent_change_7d"": 2.4947,
                                ""market_cap"": 31932960.44117946,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3020,
                        ""name"": ""BHPCash"",
                        ""symbol"": ""BHPC"",
                        ""slug"": ""bhpcash"",
                        ""circulating_supply"": 33746752,
                        ""total_supply"": 100000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-08-03T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [],
                        ""cmc_rank"": 128,
                        ""last_updated"": ""2018-12-03T04:15:29.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9423042702952501,
                                ""volume_24h"": 9270839.48134207,
                                ""percent_change_1h"": 0.6858,
                                ""percent_change_24h"": -2.4245,
                                ""percent_change_7d"": -0.4014,
                                ""market_cap"": 31799708.518194772,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2044,
                        ""name"": ""Enigma"",
                        ""symbol"": ""ENG"",
                        ""slug"": ""enigma"",
                        ""circulating_supply"": 74836171.09,
                        ""total_supply"": 150000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-13T00:00:00.000Z"",
                        ""num_market_pairs"": 25,
                        ""tags"": [],
                        ""cmc_rank"": 129,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.4224629212117759,
                                ""volume_24h"": 380878.2970907792,
                                ""percent_change_1h"": 0.5482,
                                ""percent_change_24h"": -5.7062,
                                ""percent_change_7d"": 7.0375,
                                ""market_cap"": 31615507.45098566,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2507,
                        ""name"": ""THEKEY"",
                        ""symbol"": ""TKY"",
                        ""slug"": ""thekey"",
                        ""circulating_supply"": 5060038286.99993,
                        ""total_supply"": 9795844687,
                        ""max_supply"": null,
                        ""date_added"": ""2018-02-07T00:00:00.000Z"",
                        ""num_market_pairs"": 12,
                        ""tags"": [],
                        ""cmc_rank"": 130,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.006043099449867879,
                                ""volume_24h"": 402986.0852309189,
                                ""percent_change_1h"": -0.7125,
                                ""percent_change_24h"": -1.4962,
                                ""percent_change_7d"": 11.287,
                                ""market_cap"": 30578314.58847968,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1993,
                        ""name"": ""Kin"",
                        ""symbol"": ""KIN"",
                        ""slug"": ""kin"",
                        ""circulating_supply"": 756097560976,
                        ""total_supply"": 10000000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-27T00:00:00.000Z"",
                        ""num_market_pairs"": 21,
                        ""tags"": [],
                        ""cmc_rank"": 131,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.00003928192613302663,
                                ""volume_24h"": 138426.26685693758,
                                ""percent_change_1h"": -0.494,
                                ""percent_change_24h"": -0.4567,
                                ""percent_change_7d"": 9.4433,
                                ""market_cap"": 29700968.539620835,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1816,
                        ""name"": ""Civic"",
                        ""symbol"": ""CVC"",
                        ""slug"": ""civic"",
                        ""circulating_supply"": 342699967,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-17T00:00:00.000Z"",
                        ""num_market_pairs"": 40,
                        ""tags"": [],
                        ""cmc_rank"": 132,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.08655611526072443,
                                ""volume_24h"": 1875610.875352691,
                                ""percent_change_1h"": -0.492,
                                ""percent_change_24h"": -4.5617,
                                ""percent_change_7d"": 9.3923,
                                ""market_cap"": 29662777.84349846,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2057,
                        ""name"": ""Eidoo"",
                        ""symbol"": ""EDO"",
                        ""slug"": ""eidoo"",
                        ""circulating_supply"": 29261461.2776,
                        ""total_supply"": 90208327.5853,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-17T00:00:00.000Z"",
                        ""num_market_pairs"": 11,
                        ""tags"": [],
                        ""cmc_rank"": 133,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.0073057105697112,
                                ""volume_24h"": 292253.43883526267,
                                ""percent_change_1h"": -0.161,
                                ""percent_change_24h"": -4.4356,
                                ""percent_change_7d"": -0.5353,
                                ""market_cap"": 29475237.04454096,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 541,
                        ""name"": ""Syscoin"",
                        ""symbol"": ""SYS"",
                        ""slug"": ""syscoin"",
                        ""circulating_supply"": 544233286.060324,
                        ""total_supply"": 544233286.060324,
                        ""max_supply"": 888000000,
                        ""date_added"": ""2014-08-20T00:00:00.000Z"",
                        ""num_market_pairs"": 15,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 134,
                        ""last_updated"": ""2018-12-03T04:16:05.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.05405954256371677,
                                ""volume_24h"": 258589.6938746826,
                                ""percent_change_1h"": 1.6572,
                                ""percent_change_24h"": -2.7524,
                                ""percent_change_7d"": 8.5986,
                                ""market_cap"": 29421002.49236953,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2861,
                        ""name"": ""GoChain"",
                        ""symbol"": ""GO"",
                        ""slug"": ""gochain"",
                        ""circulating_supply"": 653179708.479526,
                        ""total_supply"": 1024325651,
                        ""max_supply"": null,
                        ""date_added"": ""2018-06-13T00:00:00.000Z"",
                        ""num_market_pairs"": 12,
                        ""tags"": [],
                        ""cmc_rank"": 135,
                        ""last_updated"": ""2018-12-03T04:15:25.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.04440924715386932,
                                ""volume_24h"": 1456405.8777904892,
                                ""percent_change_1h"": -0.8728,
                                ""percent_change_24h"": -8.2166,
                                ""percent_change_7d"": -2.0653,
                                ""market_cap"": 29007219.109759584,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2538,
                        ""name"": ""Nectar"",
                        ""symbol"": ""NEC"",
                        ""slug"": ""nectar"",
                        ""circulating_supply"": 82353021.82319,
                        ""total_supply"": 1007949846.69351,
                        ""max_supply"": null,
                        ""date_added"": ""2018-02-21T00:00:00.000Z"",
                        ""num_market_pairs"": 3,
                        ""tags"": [],
                        ""cmc_rank"": 136,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.34791437330526215,
                                ""volume_24h"": 1271.449047186904,
                                ""percent_change_1h"": 0.0462,
                                ""percent_change_24h"": -4.0316,
                                ""percent_change_7d"": -14.088,
                                ""market_cap"": 28651799.97740973,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2307,
                        ""name"": ""Bibox Token"",
                        ""symbol"": ""BIX"",
                        ""slug"": ""bibox-token"",
                        ""circulating_supply"": 102384714,
                        ""total_supply"": 265986997,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-24T00:00:00.000Z"",
                        ""num_market_pairs"": 31,
                        ""tags"": [],
                        ""cmc_rank"": 137,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.27933011587006806,
                                ""volume_24h"": 1902344.048322527,
                                ""percent_change_1h"": 0.0138,
                                ""percent_change_24h"": -7.3175,
                                ""percent_change_7d"": 3.5921,
                                ""market_cap"": 28599134.024943776,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3409,
                        ""name"": ""Etheera"",
                        ""symbol"": ""ETA"",
                        ""slug"": ""etheera"",
                        ""circulating_supply"": 5857896294.0402,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-10-08T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [],
                        ""cmc_rank"": 138,
                        ""last_updated"": ""2018-12-03T04:15:36.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.004820664390426614,
                                ""volume_24h"": 12257.836946196967,
                                ""percent_change_1h"": 0.7235,
                                ""percent_change_24h"": -5.1579,
                                ""percent_change_7d"": 97.7952,
                                ""market_cap"": 28238952.067491625,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 258,
                        ""name"": ""Groestlcoin"",
                        ""symbol"": ""GRS"",
                        ""slug"": ""groestlcoin"",
                        ""circulating_supply"": 71424748.8873661,
                        ""total_supply"": 71424748.8873661,
                        ""max_supply"": 105000000,
                        ""date_added"": ""2014-04-11T00:00:00.000Z"",
                        ""num_market_pairs"": 26,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 139,
                        ""last_updated"": ""2018-12-03T04:16:03.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.39450478074203776,
                                ""volume_24h"": 3040600.6011256617,
                                ""percent_change_1h"": 0.8866,
                                ""percent_change_24h"": -2.1608,
                                ""percent_change_7d"": 10.7927,
                                ""market_cap"": 28177404.89936547,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1963,
                        ""name"": ""Credo"",
                        ""symbol"": ""CREDO"",
                        ""slug"": ""credo"",
                        ""circulating_supply"": 549891702.891,
                        ""total_supply"": 1374729257,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-13T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [],
                        ""cmc_rank"": 140,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0506351021934823,
                                ""volume_24h"": 9678.384450665666,
                                ""percent_change_1h"": -0.3782,
                                ""percent_change_24h"": 1.5245,
                                ""percent_change_7d"": 17.8041,
                                ""market_cap"": 27843822.571233794,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2130,
                        ""name"": ""Enjin Coin"",
                        ""symbol"": ""ENJ"",
                        ""slug"": ""enjin-coin"",
                        ""circulating_supply"": 761158535.064264,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-11-01T00:00:00.000Z"",
                        ""num_market_pairs"": 34,
                        ""tags"": [],
                        ""cmc_rank"": 141,
                        ""last_updated"": ""2018-12-03T04:15:16.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.03610595601808518,
                                ""volume_24h"": 1934420.2954808092,
                                ""percent_change_1h"": -0.5468,
                                ""percent_change_24h"": -9.037,
                                ""percent_change_7d"": 12.748,
                                ""market_cap"": 27482356.589820467,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2306,
                        ""name"": ""Bread"",
                        ""symbol"": ""BRD"",
                        ""slug"": ""bread"",
                        ""circulating_supply"": 88733977.6930047,
                        ""total_supply"": 88862718,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-24T00:00:00.000Z"",
                        ""num_market_pairs"": 11,
                        ""tags"": [],
                        ""cmc_rank"": 142,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3077618722120674,
                                ""volume_24h"": 122785.94324956005,
                                ""percent_change_1h"": -0.4747,
                                ""percent_change_24h"": -4.6249,
                                ""percent_change_7d"": 0.3694,
                                ""market_cap"": 27308935.103622954,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2181,
                        ""name"": ""Genesis Vision"",
                        ""symbol"": ""GVT"",
                        ""slug"": ""genesis-vision"",
                        ""circulating_supply"": 4426883.31189056,
                        ""total_supply"": 4436643.92853333,
                        ""max_supply"": null,
                        ""date_added"": ""2017-11-15T00:00:00.000Z"",
                        ""num_market_pairs"": 12,
                        ""tags"": [],
                        ""cmc_rank"": 143,
                        ""last_updated"": ""2018-12-03T04:15:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 6.045818966832678,
                                ""volume_24h"": 1152594.5940775056,
                                ""percent_change_1h"": -0.8034,
                                ""percent_change_24h"": -5.1313,
                                ""percent_change_7d"": -1.103,
                                ""market_cap"": 26764135.090983007,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2092,
                        ""name"": ""Nuls"",
                        ""symbol"": ""NULS"",
                        ""slug"": ""nuls"",
                        ""circulating_supply"": 40000000,
                        ""total_supply"": 100000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-25T00:00:00.000Z"",
                        ""num_market_pairs"": 15,
                        ""tags"": [],
                        ""cmc_rank"": 144,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.6676391229342762,
                                ""volume_24h"": 8138887.624959124,
                                ""percent_change_1h"": -0.5237,
                                ""percent_change_24h"": -3.9154,
                                ""percent_change_7d"": 2.1395,
                                ""market_cap"": 26705564.91737105,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3164,
                        ""name"": ""PumaPay"",
                        ""symbol"": ""PMA"",
                        ""slug"": ""pumapay"",
                        ""circulating_supply"": 20754856630.56,
                        ""total_supply"": 78042956829,
                        ""max_supply"": null,
                        ""date_added"": ""2018-08-13T00:00:00.000Z"",
                        ""num_market_pairs"": 7,
                        ""tags"": [],
                        ""cmc_rank"": 145,
                        ""last_updated"": ""2018-12-03T04:15:30.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.001269168949747662,
                                ""volume_24h"": 7608619.020774335,
                                ""percent_change_1h"": 4.18,
                                ""percent_change_24h"": 4.2431,
                                ""percent_change_7d"": 32.266,
                                ""market_cap"": 26341419.591971137,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2638,
                        ""name"": ""Cortex"",
                        ""symbol"": ""CTXC"",
                        ""slug"": ""cortex"",
                        ""circulating_supply"": 149792458,
                        ""total_supply"": 299792458,
                        ""max_supply"": null,
                        ""date_added"": ""2018-04-16T00:00:00.000Z"",
                        ""num_market_pairs"": 23,
                        ""tags"": [],
                        ""cmc_rank"": 146,
                        ""last_updated"": ""2018-12-03T04:15:24.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.17258678718698767,
                                ""volume_24h"": 2145955.582803096,
                                ""percent_change_1h"": -0.4319,
                                ""percent_change_24h"": -9.1218,
                                ""percent_change_7d"": 12.3477,
                                ""market_cap"": 25852199.07106179,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1996,
                        ""name"": ""SALT"",
                        ""symbol"": ""SALT"",
                        ""slug"": ""salt"",
                        ""circulating_supply"": 81280816.4419561,
                        ""total_supply"": 120000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-29T00:00:00.000Z"",
                        ""num_market_pairs"": 28,
                        ""tags"": [],
                        ""cmc_rank"": 147,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3177062635822461,
                                ""volume_24h"": 730699.0165219804,
                                ""percent_change_1h"": -0.0829,
                                ""percent_change_24h"": -3.0395,
                                ""percent_change_7d"": 9.8338,
                                ""market_cap"": 25823424.49268827,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2530,
                        ""name"": ""Fusion"",
                        ""symbol"": ""FSN"",
                        ""slug"": ""fusion"",
                        ""circulating_supply"": 29704811.2,
                        ""total_supply"": 57344000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-02-16T00:00:00.000Z"",
                        ""num_market_pairs"": 13,
                        ""tags"": [],
                        ""cmc_rank"": 148,
                        ""last_updated"": ""2018-12-03T04:15:22.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.8675681574794367,
                                ""volume_24h"": 585479.4385489953,
                                ""percent_change_1h"": 0.7297,
                                ""percent_change_24h"": -4.0401,
                                ""percent_change_7d"": -14.8648,
                                ""market_cap"": 25770948.321058538,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1492,
                        ""name"": ""Byteball Bytes"",
                        ""symbol"": ""GBYTE"",
                        ""slug"": ""byteball"",
                        ""circulating_supply"": 662810.762984421,
                        ""total_supply"": 1000000,
                        ""max_supply"": null,
                        ""date_added"": ""2016-12-27T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 149,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 38.46988276029436,
                                ""volume_24h"": 19978.56109264546,
                                ""percent_change_1h"": -0.123,
                                ""percent_change_24h"": -5.286,
                                ""percent_change_7d"": 1.7528,
                                ""market_cap"": 25498252.34427193,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1886,
                        ""name"": ""Dent"",
                        ""symbol"": ""DENT"",
                        ""slug"": ""dent"",
                        ""circulating_supply"": 17241387101.1659,
                        ""total_supply"": 100000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-08-12T00:00:00.000Z"",
                        ""num_market_pairs"": 37,
                        ""tags"": [],
                        ""cmc_rank"": 150,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0014758042797250429,
                                ""volume_24h"": 391900.33274350653,
                                ""percent_change_1h"": 1.4866,
                                ""percent_change_24h"": -5.1341,
                                ""percent_change_7d"": 0.3189,
                                ""market_cap"": 25444912.87229679,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2989,
                        ""name"": ""STASIS EURS"",
                        ""symbol"": ""EURS"",
                        ""slug"": ""stasis-eurs"",
                        ""circulating_supply"": 17291000,
                        ""total_supply"": 17291000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-07-30T00:00:00.000Z"",
                        ""num_market_pairs"": 18,
                        ""tags"": [],
                        ""cmc_rank"": 151,
                        ""last_updated"": ""2018-12-03T04:15:28.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.4680052957494234,
                                ""volume_24h"": 92742.25731078978,
                                ""percent_change_1h"": -0.6515,
                                ""percent_change_24h"": -0.548,
                                ""percent_change_7d"": -0.7153,
                                ""market_cap"": 25383279.56880328,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1984,
                        ""name"": ""Substratum"",
                        ""symbol"": ""SUB"",
                        ""slug"": ""substratum"",
                        ""circulating_supply"": 383020999.96,
                        ""total_supply"": 472000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-25T00:00:00.000Z"",
                        ""num_market_pairs"": 20,
                        ""tags"": [],
                        ""cmc_rank"": 152,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.06619352977279055,
                                ""volume_24h"": 165410.24338062014,
                                ""percent_change_1h"": 1.1376,
                                ""percent_change_24h"": -6.1023,
                                ""percent_change_7d"": 11.3713,
                                ""market_cap"": 25353511.964456268,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2381,
                        ""name"": ""Spectre.ai Dividend Token"",
                        ""symbol"": ""SXDT"",
                        ""slug"": ""spectre-dividend"",
                        ""circulating_supply"": 82073518.6243884,
                        ""total_supply"": 140270691.248777,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-12T00:00:00.000Z"",
                        ""num_market_pairs"": 1,
                        ""tags"": [],
                        ""cmc_rank"": 153,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3076762609968899,
                                ""volume_24h"": 1452.0230322217997,
                                ""percent_change_1h"": -7.0509,
                                ""percent_change_24h"": 1.0844,
                                ""percent_change_7d"": 1.6894,
                                ""market_cap"": 25252073.33721043,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 5,
                        ""name"": ""Peercoin"",
                        ""symbol"": ""PPC"",
                        ""slug"": ""peercoin"",
                        ""circulating_supply"": 25078974.7816733,
                        ""total_supply"": 25078974.7816733,
                        ""max_supply"": null,
                        ""date_added"": ""2013-04-28T00:00:00.000Z"",
                        ""num_market_pairs"": 18,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 154,
                        ""last_updated"": ""2018-12-03T04:16:02.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.9639871425277694,
                                ""volume_24h"": 170414.2118866868,
                                ""percent_change_1h"": 1.0635,
                                ""percent_change_24h"": -3.8345,
                                ""percent_change_7d"": 0.8863,
                                ""market_cap"": 24175809.237311237,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1828,
                        ""name"": ""SmartCash"",
                        ""symbol"": ""SMART"",
                        ""slug"": ""smartcash"",
                        ""circulating_supply"": 1053773051.84877,
                        ""total_supply"": 1654817331.04877,
                        ""max_supply"": 5000000000,
                        ""date_added"": ""2017-07-21T00:00:00.000Z"",
                        ""num_market_pairs"": 30,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 155,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.023443076977255166,
                                ""volume_24h"": 446445.5759710937,
                                ""percent_change_1h"": -0.9818,
                                ""percent_change_24h"": -1.598,
                                ""percent_change_7d"": -6.4442,
                                ""market_cap"": 24703682.771047816,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3388,
                        ""name"": ""FREE Coin"",
                        ""symbol"": ""FREE"",
                        ""slug"": ""free-coin"",
                        ""circulating_supply"": 3812440461104.59,
                        ""total_supply"": 10000000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-10-04T00:00:00.000Z"",
                        ""num_market_pairs"": 14,
                        ""tags"": [],
                        ""cmc_rank"": 156,
                        ""last_updated"": ""2018-12-03T04:15:33.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.000006379762684384073,
                                ""volume_24h"": 3506.3367299890183,
                                ""percent_change_1h"": 1.0867,
                                ""percent_change_24h"": -370.513,
                                ""percent_change_7d"": 96.4407,
                                ""market_cap"": 24322465.39019107,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2071,
                        ""name"": ""Request Network"",
                        ""symbol"": ""REQ"",
                        ""slug"": ""request-network"",
                        ""circulating_supply"": 729658688.341129,
                        ""total_supply"": 999988451.501129,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-20T00:00:00.000Z"",
                        ""num_market_pairs"": 34,
                        ""tags"": [],
                        ""cmc_rank"": 157,
                        ""last_updated"": ""2018-12-03T04:15:16.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.03276273386644543,
                                ""volume_24h"": 924997.0837994316,
                                ""percent_change_1h"": 1.0765,
                                ""percent_change_24h"": -6.1577,
                                ""percent_change_7d"": 9.3437,
                                ""market_cap"": 23905613.41946006,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2297,
                        ""name"": ""Storm"",
                        ""symbol"": ""STORM"",
                        ""slug"": ""storm"",
                        ""circulating_supply"": 4518781114.41287,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-20T00:00:00.000Z"",
                        ""num_market_pairs"": 23,
                        ""tags"": [],
                        ""cmc_rank"": 158,
                        ""last_updated"": ""2018-12-03T04:15:18.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0052800866129307684,
                                ""volume_24h"": 824841.3925468642,
                                ""percent_change_1h"": -0.2949,
                                ""percent_change_24h"": -5.3412,
                                ""percent_change_7d"": 9.9801,
                                ""market_cap"": 23859555.668975774,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2576,
                        ""name"": ""Tokenomy"",
                        ""symbol"": ""TEN"",
                        ""slug"": ""tokenomy"",
                        ""circulating_supply"": 200000000,
                        ""total_supply"": 200000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-10T00:00:00.000Z"",
                        ""num_market_pairs"": 20,
                        ""tags"": [],
                        ""cmc_rank"": 159,
                        ""last_updated"": ""2018-12-03T04:15:24.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.11831024991566629,
                                ""volume_24h"": 646893.3544069376,
                                ""percent_change_1h"": 0.2107,
                                ""percent_change_24h"": -2.1112,
                                ""percent_change_7d"": 9.2512,
                                ""market_cap"": 23662049.983133256,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1637,
                        ""name"": ""iExec RLC"",
                        ""symbol"": ""RLC"",
                        ""slug"": ""rlc"",
                        ""circulating_supply"": 80070793.2387674,
                        ""total_supply"": 86999784.9868455,
                        ""max_supply"": null,
                        ""date_added"": ""2017-04-20T00:00:00.000Z"",
                        ""num_market_pairs"": 16,
                        ""tags"": [],
                        ""cmc_rank"": 160,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.2947741571874996,
                                ""volume_24h"": 262600.8580178049,
                                ""percent_change_1h"": -0.2507,
                                ""percent_change_24h"": -6.7386,
                                ""percent_change_7d"": 8.3988,
                                ""market_cap"": 23602800.5922922,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2765,
                        ""name"": ""XYO Network"",
                        ""symbol"": ""XYO"",
                        ""slug"": ""xyo-network"",
                        ""circulating_supply"": 5539553175.0374,
                        ""total_supply"": 14198847000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-05-22T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [],
                        ""cmc_rank"": 161,
                        ""last_updated"": ""2018-12-03T04:15:26.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.004251189724227629,
                                ""volume_24h"": 78233.58454609202,
                                ""percent_change_1h"": -4.7937,
                                ""percent_change_24h"": -29.5837,
                                ""percent_change_7d"": 39.2982,
                                ""market_cap"": 23549691.53453153,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1408,
                        ""name"": ""Iconomi"",
                        ""symbol"": ""ICN"",
                        ""slug"": ""iconomi"",
                        ""circulating_supply"": 98930339.7729087,
                        ""total_supply"": 98930339.7729087,
                        ""max_supply"": null,
                        ""date_added"": ""2016-09-30T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [],
                        ""cmc_rank"": 162,
                        ""last_updated"": ""2018-12-03T04:16:08.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.23682396088544114,
                                ""volume_24h"": 987.4811200070357,
                                ""percent_change_1h"": -0.1041,
                                ""percent_change_24h"": -6.6889,
                                ""percent_change_7d"": -7.2394,
                                ""market_cap"": 23429074.916762732,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1954,
                        ""name"": ""Moeda Loyalty Points"",
                        ""symbol"": ""MDA"",
                        ""slug"": ""moeda-loyalty-points"",
                        ""circulating_supply"": 19628888,
                        ""total_supply"": 19628888,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-11T00:00:00.000Z"",
                        ""num_market_pairs"": 9,
                        ""tags"": [],
                        ""cmc_rank"": 163,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.1840581119597622,
                                ""volume_24h"": 5424409.532651783,
                                ""percent_change_1h"": -0.6794,
                                ""percent_change_24h"": -6.1607,
                                ""percent_change_7d"": 18.0373,
                                ""market_cap"": 23241744.065149628,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2043,
                        ""name"": ""Cindicator"",
                        ""symbol"": ""CND"",
                        ""slug"": ""cindicator"",
                        ""circulating_supply"": 1445976590.32706,
                        ""total_supply"": 2000000004.61,
                        ""max_supply"": null,
                        ""date_added"": ""2017-10-13T00:00:00.000Z"",
                        ""num_market_pairs"": 17,
                        ""tags"": [],
                        ""cmc_rank"": 164,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.01590372615582251,
                                ""volume_24h"": 113936.78844504332,
                                ""percent_change_1h"": -0.0132,
                                ""percent_change_24h"": -6.4005,
                                ""percent_change_7d"": 5.7558,
                                ""market_cap"": 22996415.720291514,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2458,
                        ""name"": ""Odyssey"",
                        ""symbol"": ""OCN"",
                        ""slug"": ""odyssey"",
                        ""circulating_supply"": 4750000000,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-24T00:00:00.000Z"",
                        ""num_market_pairs"": 24,
                        ""tags"": [],
                        ""cmc_rank"": 165,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.004835877974983496,
                                ""volume_24h"": 2211646.4418451935,
                                ""percent_change_1h"": 0.2004,
                                ""percent_change_24h"": -4.2651,
                                ""percent_change_7d"": -6.9411,
                                ""market_cap"": 22970420.38117161,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3134,
                        ""name"": ""ETERNAL TOKEN"",
                        ""symbol"": ""XET"",
                        ""slug"": ""eternal-token"",
                        ""circulating_supply"": 67930001,
                        ""total_supply"": 200000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-08-09T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [],
                        ""cmc_rank"": 166,
                        ""last_updated"": ""2018-12-03T04:15:29.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.33722459873895594,
                                ""volume_24h"": 262739.7524776574,
                                ""percent_change_1h"": -8.4339,
                                ""percent_change_24h"": 9.0828,
                                ""percent_change_7d"": -10.7015,
                                ""market_cap"": 22907667.329561874,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 789,
                        ""name"": ""Nexus"",
                        ""symbol"": ""NXS"",
                        ""slug"": ""nexus"",
                        ""circulating_supply"": 59707886.23,
                        ""total_supply"": 59907495,
                        ""max_supply"": null,
                        ""date_added"": ""2015-01-25T00:00:00.000Z"",
                        ""num_market_pairs"": 6,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 167,
                        ""last_updated"": ""2018-12-03T04:16:06.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3653954980995093,
                                ""volume_24h"": 253463.01465680773,
                                ""percent_change_1h"": 0.6982,
                                ""percent_change_24h"": -9.5262,
                                ""percent_change_7d"": 4.4334,
                                ""market_cap"": 21816992.829479683,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2930,
                        ""name"": ""Everipedia"",
                        ""symbol"": ""IQ"",
                        ""slug"": ""everipedia"",
                        ""circulating_supply"": 4506302132.79,
                        ""total_supply"": 9998572887.67,
                        ""max_supply"": 10000000000,
                        ""date_added"": ""2018-07-13T00:00:00.000Z"",
                        ""num_market_pairs"": 7,
                        ""tags"": [],
                        ""cmc_rank"": 168,
                        ""last_updated"": ""2018-12-03T04:15:28.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0048453868979734215,
                                ""volume_24h"": 311629.48907957587,
                                ""percent_change_1h"": 1.4819,
                                ""percent_change_24h"": -7.9251,
                                ""percent_change_7d"": 4.948,
                                ""market_cap"": 21834777.31253035,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2289,
                        ""name"": ""Gifto"",
                        ""symbol"": ""GTO"",
                        ""slug"": ""gifto"",
                        ""circulating_supply"": 531819169.31438,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-12-18T00:00:00.000Z"",
                        ""num_market_pairs"": 29,
                        ""tags"": [],
                        ""cmc_rank"": 169,
                        ""last_updated"": ""2018-12-03T04:16:15.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0407965590123532,
                                ""volume_24h"": 4052702.1962657734,
                                ""percent_change_1h"": 0.8195,
                                ""percent_change_24h"": -5.0229,
                                ""percent_change_7d"": 12.4115,
                                ""market_cap"": 21696392.12483476,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1834,
                        ""name"": ""Pillar"",
                        ""symbol"": ""PLR"",
                        ""slug"": ""pillar"",
                        ""circulating_supply"": 259348201,
                        ""total_supply"": 800000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-24T00:00:00.000Z"",
                        ""num_market_pairs"": 8,
                        ""tags"": [],
                        ""cmc_rank"": 170,
                        ""last_updated"": ""2018-12-03T04:16:10.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.08214605646632397,
                                ""volume_24h"": 15834.679497102412,
                                ""percent_change_1h"": -4.3567,
                                ""percent_change_24h"": 1.1741,
                                ""percent_change_7d"": 14.8248,
                                ""market_cap"": 21304431.96378554,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2276,
                        ""name"": ""Ignis"",
                        ""symbol"": ""IGNIS"",
                        ""slug"": ""ignis"",
                        ""circulating_supply"": 761143950,
                        ""total_supply"": 999449694,
                        ""max_supply"": 999449694,
                        ""date_added"": ""2017-12-13T00:00:00.000Z"",
                        ""num_market_pairs"": 8,
                        ""tags"": [],
                        ""cmc_rank"": 171,
                        ""last_updated"": ""2018-12-03T04:15:18.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.027735020598903298,
                                ""volume_24h"": 66138.54776992009,
                                ""percent_change_1h"": 0.1932,
                                ""percent_change_24h"": -3.1201,
                                ""percent_change_7d"": 12.6988,
                                ""market_cap"": 21110343.13198062,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2021,
                        ""name"": ""RChain"",
                        ""symbol"": ""RHOC"",
                        ""slug"": ""rchain"",
                        ""circulating_supply"": 373789867.795,
                        ""total_supply"": 870663574,
                        ""max_supply"": 1000000000,
                        ""date_added"": ""2017-10-06T00:00:00.000Z"",
                        ""num_market_pairs"": 14,
                        ""tags"": [],
                        ""cmc_rank"": 172,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.056106033643496776,
                                ""volume_24h"": 162520.35944485315,
                                ""percent_change_1h"": -0.0686,
                                ""percent_change_24h"": -2.0279,
                                ""percent_change_7d"": -10.6357,
                                ""market_cap"": 20971866.89810448,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1807,
                        ""name"": ""Santiment Network Token"",
                        ""symbol"": ""SAN"",
                        ""slug"": ""santiment"",
                        ""circulating_supply"": 62660370.9569795,
                        ""total_supply"": 83337000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-12T00:00:00.000Z"",
                        ""num_market_pairs"": 11,
                        ""tags"": [],
                        ""cmc_rank"": 173,
                        ""last_updated"": ""2018-12-03T04:16:13.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3339190047352081,
                                ""volume_24h"": 428617.68118370924,
                                ""percent_change_1h"": -0.0807,
                                ""percent_change_24h"": -2.5321,
                                ""percent_change_7d"": 4.8102,
                                ""market_cap"": 20923488.70629353,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2896,
                        ""name"": ""Mainframe"",
                        ""symbol"": ""MFT"",
                        ""slug"": ""mainframe"",
                        ""circulating_supply"": 3937700694.0375,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-07-05T00:00:00.000Z"",
                        ""num_market_pairs"": 12,
                        ""tags"": [],
                        ""cmc_rank"": 174,
                        ""last_updated"": ""2018-12-03T04:15:28.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.005221237640866594,
                                ""volume_24h"": 1398554.1898421526,
                                ""percent_change_1h"": 0.1196,
                                ""percent_change_24h"": -4.6755,
                                ""percent_change_7d"": 6.6181,
                                ""market_cap"": 20559671.082175106,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 99,
                        ""name"": ""Vertcoin"",
                        ""symbol"": ""VTC"",
                        ""slug"": ""vertcoin"",
                        ""circulating_supply"": 47123225,
                        ""total_supply"": 47123225,
                        ""max_supply"": 84000000,
                        ""date_added"": ""2014-01-20T00:00:00.000Z"",
                        ""num_market_pairs"": 18,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 175,
                        ""last_updated"": ""2018-12-03T04:16:02.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.4327786931648542,
                                ""volume_24h"": 789444.1113960295,
                                ""percent_change_1h"": 0.8004,
                                ""percent_change_24h"": -3.9102,
                                ""percent_change_7d"": 7.9648,
                                ""market_cap"": 20393927.733213387,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 558,
                        ""name"": ""Emercoin"",
                        ""symbol"": ""EMC"",
                        ""slug"": ""emercoin"",
                        ""circulating_supply"": 42118422.317629,
                        ""total_supply"": 42118422.317629,
                        ""max_supply"": null,
                        ""date_added"": ""2014-08-23T00:00:00.000Z"",
                        ""num_market_pairs"": 12,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 176,
                        ""last_updated"": ""2018-12-03T04:16:05.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.48686693191684466,
                                ""volume_24h"": 83031.19029338864,
                                ""percent_change_1h"": -0.3715,
                                ""percent_change_24h"": -9.7085,
                                ""percent_change_7d"": -5.6848,
                                ""market_cap"": 20506067.05096199,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2394,
                        ""name"": ""Telcoin"",
                        ""symbol"": ""TEL"",
                        ""slug"": ""telcoin"",
                        ""circulating_supply"": 34898527174.98,
                        ""total_supply"": 100000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-14T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 177,
                        ""last_updated"": ""2018-12-03T04:15:18.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0005820080300909784,
                                ""volume_24h"": 26363.341311879263,
                                ""percent_change_1h"": -0.0383,
                                ""percent_change_24h"": -5.3295,
                                ""percent_change_7d"": 9.6607,
                                ""market_cap"": 20311223.05418659,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3598,
                        ""name"": ""Optimal Shelf Availability Token"",
                        ""symbol"": ""OSA"",
                        ""slug"": ""optimal-shelf-availability-token"",
                        ""circulating_supply"": 318565451.529526,
                        ""total_supply"": 5777223968.49,
                        ""max_supply"": null,
                        ""date_added"": ""2018-11-07T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 178,
                        ""last_updated"": ""2018-12-03T04:15:36.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0633324482589682,
                                ""volume_24h"": 1191219.7740309138,
                                ""percent_change_1h"": 3.2939,
                                ""percent_change_24h"": 7.29,
                                ""percent_change_7d"": -26.4832,
                                ""market_cap"": 20175529.976088546,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2599,
                        ""name"": ""Noah Coin"",
                        ""symbol"": ""NOAH"",
                        ""slug"": ""noah-coin"",
                        ""circulating_supply"": 32687957977.6,
                        ""total_supply"": 91584000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-21T00:00:00.000Z"",
                        ""num_market_pairs"": 13,
                        ""tags"": [],
                        ""cmc_rank"": 179,
                        ""last_updated"": ""2018-12-03T04:15:23.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0006146958247688742,
                                ""volume_24h"": 424459.9850262926,
                                ""percent_change_1h"": -1.2354,
                                ""percent_change_24h"": -9.9948,
                                ""percent_change_7d"": 17.4792,
                                ""market_cap"": 20093151.289051134,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2474,
                        ""name"": ""Matrix AI Network"",
                        ""symbol"": ""MAN"",
                        ""slug"": ""matrix-ai-network"",
                        ""circulating_supply"": 150000000,
                        ""total_supply"": 250000000,
                        ""max_supply"": 1000000000,
                        ""date_added"": ""2018-01-27T00:00:00.000Z"",
                        ""num_market_pairs"": 16,
                        ""tags"": [],
                        ""cmc_rank"": 180,
                        ""last_updated"": ""2018-12-03T04:15:20.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.13376583702356828,
                                ""volume_24h"": 1224168.1283340459,
                                ""percent_change_1h"": -5.5899,
                                ""percent_change_24h"": -8.1577,
                                ""percent_change_7d"": 3.9187,
                                ""market_cap"": 20064875.553535245,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2444,
                        ""name"": ""CRYPTO20"",
                        ""symbol"": ""C20"",
                        ""slug"": ""c20"",
                        ""circulating_supply"": 40199297.8961672,
                        ""total_supply"": 40656081.9801672,
                        ""max_supply"": null,
                        ""date_added"": ""2018-01-22T00:00:00.000Z"",
                        ""num_market_pairs"": 3,
                        ""tags"": [],
                        ""cmc_rank"": 181,
                        ""last_updated"": ""2018-12-03T04:15:21.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.49588471237452103,
                                ""volume_24h"": 2940.343271811262,
                                ""percent_change_1h"": 0.1102,
                                ""percent_change_24h"": -3.6881,
                                ""percent_change_7d"": -0.5462,
                                ""market_cap"": 19934217.27489856,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2727,
                        ""name"": ""Bezant"",
                        ""symbol"": ""BZNT"",
                        ""slug"": ""bezant"",
                        ""circulating_supply"": 496808816.249999,
                        ""total_supply"": 1000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-05-11T00:00:00.000Z"",
                        ""num_market_pairs"": 10,
                        ""tags"": [],
                        ""cmc_rank"": 182,
                        ""last_updated"": ""2018-12-03T04:15:25.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.0401198964303767,
                                ""volume_24h"": 949643.5876805097,
                                ""percent_change_1h"": 0.1784,
                                ""percent_change_24h"": -12.5294,
                                ""percent_change_7d"": 46.5157,
                                ""market_cap"": 19931918.25364801,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2556,
                        ""name"": ""Credits"",
                        ""symbol"": ""CS"",
                        ""slug"": ""credits"",
                        ""circulating_supply"": 152434130.05869,
                        ""total_supply"": 249471071.20999,
                        ""max_supply"": null,
                        ""date_added"": ""2018-03-02T00:00:00.000Z"",
                        ""num_market_pairs"": 18,
                        ""tags"": [],
                        ""cmc_rank"": 183,
                        ""last_updated"": ""2018-12-03T04:15:23.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.13035084118631027,
                                ""volume_24h"": 2093409.2441923984,
                                ""percent_change_1h"": -4.1804,
                                ""percent_change_24h"": -7.0693,
                                ""percent_change_7d"": 7.1236,
                                ""market_cap"": 19869917.078653663,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 201,
                        ""name"": ""Einsteinium"",
                        ""symbol"": ""EMC2"",
                        ""slug"": ""einsteinium"",
                        ""circulating_supply"": 217992308.599999,
                        ""total_supply"": 217992308.599999,
                        ""max_supply"": null,
                        ""date_added"": ""2014-04-09T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 184,
                        ""last_updated"": ""2018-12-03T04:16:04.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.09038215854105083,
                                ""volume_24h"": 740634.5370506526,
                                ""percent_change_1h"": -0.1276,
                                ""percent_change_24h"": -3.1619,
                                ""percent_change_7d"": 10.3048,
                                ""market_cap"": 19702615.39661479,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2767,
                        ""name"": ""APIS"",
                        ""symbol"": ""APIS"",
                        ""slug"": ""apis"",
                        ""circulating_supply"": 4873324620.51818,
                        ""total_supply"": 9520000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-05-23T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 185,
                        ""last_updated"": ""2018-12-03T04:15:26.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.004021447487407122,
                                ""volume_24h"": 4287119.669196965,
                                ""percent_change_1h"": 0.0084,
                                ""percent_change_24h"": -11.5947,
                                ""percent_change_7d"": 9.2262,
                                ""market_cap"": 19597819.050502095,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2985,
                        ""name"": ""ARBITRAGE"",
                        ""symbol"": ""ARB"",
                        ""slug"": ""arbitrage"",
                        ""circulating_supply"": 4359121.53744898,
                        ""total_supply"": 8761815.41117645,
                        ""max_supply"": null,
                        ""date_added"": ""2018-07-27T00:00:00.000Z"",
                        ""num_market_pairs"": 2,
                        ""tags"": [],
                        ""cmc_rank"": 186,
                        ""last_updated"": ""2018-12-03T04:15:29.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 4.417029768699927,
                                ""volume_24h"": 70746.2435929402,
                                ""percent_change_1h"": 5.0893,
                                ""percent_change_24h"": 24.6109,
                                ""percent_change_7d"": -14.4043,
                                ""market_cap"": 19254369.59629314,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1955,
                        ""name"": ""Neblio"",
                        ""symbol"": ""NEBL"",
                        ""slug"": ""neblio"",
                        ""circulating_supply"": 13788416.747677,
                        ""total_supply"": 14543115.4263232,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-12T00:00:00.000Z"",
                        ""num_market_pairs"": 10,
                        ""tags"": [],
                        ""cmc_rank"": 187,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.392008409955263,
                                ""volume_24h"": 174970.06631139404,
                                ""percent_change_1h"": 0.4096,
                                ""percent_change_24h"": -6.9774,
                                ""percent_change_7d"": 10.0676,
                                ""market_cap"": 19193592.07273438,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3415,
                        ""name"": ""Buggyra Coin Zero"",
                        ""symbol"": ""BCZERO"",
                        ""slug"": ""buggyra-coin-zero"",
                        ""circulating_supply"": 1409460286.46,
                        ""total_supply"": 10000000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-10-09T00:00:00.000Z"",
                        ""num_market_pairs"": 3,
                        ""tags"": [],
                        ""cmc_rank"": 188,
                        ""last_updated"": ""2018-12-03T04:15:36.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.013167894044361072,
                                ""volume_24h"": 41796.041310575856,
                                ""percent_change_1h"": -14.0784,
                                ""percent_change_24h"": -14.3418,
                                ""percent_change_7d"": -5.247,
                                ""market_cap"": 18559623.711840086,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2143,
                        ""name"": ""Streamr DATAcoin"",
                        ""symbol"": ""DATA"",
                        ""slug"": ""streamr-datacoin"",
                        ""circulating_supply"": 677154514,
                        ""total_supply"": 987154514,
                        ""max_supply"": null,
                        ""date_added"": ""2017-11-03T00:00:00.000Z"",
                        ""num_market_pairs"": 17,
                        ""tags"": [],
                        ""cmc_rank"": 189,
                        ""last_updated"": ""2018-12-03T04:15:16.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.027140902816637502,
                                ""volume_24h"": 1796334.106729528,
                                ""percent_change_1h"": 0.4959,
                                ""percent_change_24h"": 0.4231,
                                ""percent_change_7d"": 15.3932,
                                ""market_cap"": 18378584.8563214,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2503,
                        ""name"": ""DMarket"",
                        ""symbol"": ""DMT"",
                        ""slug"": ""dmarket"",
                        ""circulating_supply"": 50216064.1984556,
                        ""total_supply"": 56921773.1719715,
                        ""max_supply"": null,
                        ""date_added"": ""2018-02-03T00:00:00.000Z"",
                        ""num_market_pairs"": 9,
                        ""tags"": [],
                        ""cmc_rank"": 190,
                        ""last_updated"": ""2018-12-03T04:15:21.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3631765884166863,
                                ""volume_24h"": 9402045.67308942,
                                ""percent_change_1h"": -4.8631,
                                ""percent_change_24h"": 11.0468,
                                ""percent_change_7d"": 40.9715,
                                ""market_cap"": 18237298.87930841,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1937,
                        ""name"": ""Po.et"",
                        ""symbol"": ""POE"",
                        ""slug"": ""poet"",
                        ""circulating_supply"": 2417769706,
                        ""total_supply"": 3141592653,
                        ""max_supply"": null,
                        ""date_added"": ""2017-09-01T00:00:00.000Z"",
                        ""num_market_pairs"": 13,
                        ""tags"": [],
                        ""cmc_rank"": 191,
                        ""last_updated"": ""2018-12-03T04:16:14.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.007463447701277889,
                                ""volume_24h"": 235462.71641673788,
                                ""percent_change_1h"": -0.1286,
                                ""percent_change_24h"": -6.3678,
                                ""percent_change_7d"": 2.2031,
                                ""market_cap"": 18044897.754465017,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2627,
                        ""name"": ""TokenPay"",
                        ""symbol"": ""TPAY"",
                        ""slug"": ""tokenpay"",
                        ""circulating_supply"": 15691028.1588311,
                        ""total_supply"": 19670123.7718302,
                        ""max_supply"": 25000000,
                        ""date_added"": ""2018-04-05T00:00:00.000Z"",
                        ""num_market_pairs"": 14,
                        ""tags"": [],
                        ""cmc_rank"": 192,
                        ""last_updated"": ""2018-12-03T04:15:23.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.1466160060362094,
                                ""volume_24h"": 234365.13875194854,
                                ""percent_change_1h"": -0.8582,
                                ""percent_change_24h"": -3.9089,
                                ""percent_change_7d"": -11.098,
                                ""market_cap"": 17991584.03808061,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 2161,
                        ""name"": ""Raiden Network Token"",
                        ""symbol"": ""RDN"",
                        ""slug"": ""raiden-network-token"",
                        ""circulating_supply"": 50218936,
                        ""total_supply"": 100000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-11-08T00:00:00.000Z"",
                        ""num_market_pairs"": 25,
                        ""tags"": [],
                        ""cmc_rank"": 193,
                        ""last_updated"": ""2018-12-03T04:15:16.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.3561323941852004,
                                ""volume_24h"": 974635.480322739,
                                ""percent_change_1h"": 2.0229,
                                ""percent_change_24h"": -4.503,
                                ""percent_change_7d"": 16.1644,
                                ""market_cap"": 17884589.911113348,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1779,
                        ""name"": ""Wagerr"",
                        ""symbol"": ""WGR"",
                        ""slug"": ""wagerr"",
                        ""circulating_supply"": 183000000,
                        ""total_supply"": 198360471,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-05T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [],
                        ""cmc_rank"": 194,
                        ""last_updated"": ""2018-12-03T04:16:12.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.09608172487163644,
                                ""volume_24h"": 22959.49343979444,
                                ""percent_change_1h"": 1.9217,
                                ""percent_change_24h"": -9.0049,
                                ""percent_change_7d"": 1.5185,
                                ""market_cap"": 17582955.651509468,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1826,
                        ""name"": ""Particl"",
                        ""symbol"": ""PART"",
                        ""slug"": ""particl"",
                        ""circulating_supply"": 8069480,
                        ""total_supply"": 9065480,
                        ""max_supply"": null,
                        ""date_added"": ""2017-07-20T00:00:00.000Z"",
                        ""num_market_pairs"": 4,
                        ""tags"": [],
                        ""cmc_rank"": 195,
                        ""last_updated"": ""2018-12-03T04:16:10.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 2.177474992988234,
                                ""volume_24h"": 84181.66264570729,
                                ""percent_change_1h"": 0.1328,
                                ""percent_change_24h"": -11.6422,
                                ""percent_change_7d"": 12.9219,
                                ""market_cap"": 17571090.906418692,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3063,
                        ""name"": ""Vitae"",
                        ""symbol"": ""VITAE"",
                        ""slug"": ""vitae"",
                        ""circulating_supply"": 10273828.2994289,
                        ""total_supply"": 10273828.2994289,
                        ""max_supply"": null,
                        ""date_added"": ""2018-08-14T00:00:00.000Z"",
                        ""num_market_pairs"": 5,
                        ""tags"": [
                            ""mineable""
                        ],
                        ""cmc_rank"": 196,
                        ""last_updated"": ""2018-12-03T04:15:29.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 1.7070571912429737,
                                ""volume_24h"": 67876.44280959628,
                                ""percent_change_1h"": -0.5829,
                                ""percent_change_24h"": -16.6907,
                                ""percent_change_7d"": -15.5161,
                                ""market_cap"": 17538012.480135676,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3260,
                        ""name"": ""AMO Coin"",
                        ""symbol"": ""AMO"",
                        ""slug"": ""amo-coin"",
                        ""circulating_supply"": 8972250815.30714,
                        ""total_supply"": 19679012761.8104,
                        ""max_supply"": null,
                        ""date_added"": ""2018-09-10T00:00:00.000Z"",
                        ""num_market_pairs"": 3,
                        ""tags"": [],
                        ""cmc_rank"": 197,
                        ""last_updated"": ""2018-12-03T04:15:37.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.001946615173231133,
                                ""volume_24h"": 188342.11559128732,
                                ""percent_change_1h"": 1.8131,
                                ""percent_change_24h"": 0.2787,
                                ""percent_change_7d"": 12.2506,
                                ""market_cap"": 17465519.575112283,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1659,
                        ""name"": ""Gnosis"",
                        ""symbol"": ""GNO"",
                        ""slug"": ""gnosis-gno"",
                        ""circulating_supply"": 1104590,
                        ""total_supply"": 10000000,
                        ""max_supply"": null,
                        ""date_added"": ""2017-05-01T00:00:00.000Z"",
                        ""num_market_pairs"": 25,
                        ""tags"": [],
                        ""cmc_rank"": 198,
                        ""last_updated"": ""2018-12-03T04:16:09.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 15.804290845850137,
                                ""volume_24h"": 674883.1781164062,
                                ""percent_change_1h"": 0.2888,
                                ""percent_change_24h"": -3.215,
                                ""percent_change_7d"": 10.9336,
                                ""market_cap"": 17457261.6254176,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 1680,
                        ""name"": ""Aragon"",
                        ""symbol"": ""ANT"",
                        ""slug"": ""aragon"",
                        ""circulating_supply"": 29102722.8544603,
                        ""total_supply"": 39609523.8095238,
                        ""max_supply"": null,
                        ""date_added"": ""2017-05-18T00:00:00.000Z"",
                        ""num_market_pairs"": 13,
                        ""tags"": [],
                        ""cmc_rank"": 199,
                        ""last_updated"": ""2018-12-03T04:16:11.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.5940071210983183,
                                ""volume_24h"": 153077.3333443304,
                                ""percent_change_1h"": -0.0784,
                                ""percent_change_24h"": -2.4914,
                                ""percent_change_7d"": 28.2724,
                                ""market_cap"": 17287224.618900195,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    },
                    {
                        ""id"": 3475,
                        ""name"": ""BOX Token"",
                        ""symbol"": ""BOX"",
                        ""slug"": ""box-token"",
                        ""circulating_supply"": 76120523.4464304,
                        ""total_supply"": 100000000,
                        ""max_supply"": null,
                        ""date_added"": ""2018-10-19T00:00:00.000Z"",
                        ""num_market_pairs"": 7,
                        ""tags"": [],
                        ""cmc_rank"": 200,
                        ""last_updated"": ""2018-12-03T04:15:32.000Z"",
                        ""quote"": {
                            ""CAD"": {
                                ""price"": 0.22476625281804136,
                                ""volume_24h"": 2384875.356133995,
                                ""percent_change_1h"": 0.0927,
                                ""percent_change_24h"": -6.5625,
                                ""percent_change_7d"": 3.1361,
                                ""market_cap"": 17109324.81760202,
                                ""last_updated"": ""2018-12-03T04:15:01.000Z""
                            }
                        }
                    }
                ]
            }
            ";
            }
        }
    }
}
