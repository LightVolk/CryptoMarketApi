﻿using Bitfinex.Converters;
using Newtonsoft.Json;

namespace Bitfinex.Json.Objects
{
    [JsonConverter(typeof(BitfinexResultConverter))]
    public class BitfinexWallet
    {
        [BitfinexProperty(0), JsonConverter(typeof(WalletTypeConverter))]
        public WalletType Type { get; set; }

        [BitfinexProperty(1)]
        public string Currency { get; set; }

        [BitfinexProperty(2)]
        public decimal Balance { get; set; }

        [BitfinexProperty(3)]
        public decimal UnsettledInterest { get; set; }

        [BitfinexProperty(4)]
        public decimal? BalanceAvailable { get; set; }
    }
}
