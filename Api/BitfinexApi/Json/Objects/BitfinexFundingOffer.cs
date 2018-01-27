﻿using System;
using Bitfinex.Converters;
using Newtonsoft.Json;

namespace Bitfinex.Json.Objects
{
    [JsonConverter(typeof(BitfinexResultConverter))]
    public class BitfinexFundingOffer
    {
        [BitfinexProperty(0)]
        public long Id { get; set; }

        [BitfinexProperty(1)]
        public string Symbol { get; set; }

        [BitfinexProperty(2), JsonConverter(typeof(TimestampConverter))]
        public DateTime TimestampCreated { get; set; }

        [BitfinexProperty(3), JsonConverter(typeof(TimestampConverter))]
        public DateTime TimestampUpdated { get; set; }

        [BitfinexProperty(4)]
        public decimal Amount { get; set; }

        [BitfinexProperty(5)]
        public decimal AmountOriginal { get; set; }

        [BitfinexProperty(6), JsonConverter(typeof(FundingTypeConverter))]
        public FundingType FundingType { get; set; }

        [BitfinexProperty(7)]
        internal string PlaceHolder1 { get; set; }

        [BitfinexProperty(8)]
        internal string PlaceHolder2 { get; set; }

        [BitfinexProperty(9)]
        public int? Flags { get; set; }

        [BitfinexProperty(10), JsonConverter(typeof(OrderStatusConverter))]
        public OrderStatus Status { get; set; }

        [BitfinexProperty(11)]
        internal string PlaceHolder3 { get; set; }

        [BitfinexProperty(12)]
        internal string PlaceHolder4 { get; set; }

        [BitfinexProperty(13)]
        internal string PlaceHolder5 { get; set; }

        [BitfinexProperty(14)]
        public decimal Rate { get; set; }

        [BitfinexProperty(15)]
        public int Period { get; set; }

        [BitfinexProperty(16)]
        public bool Notify { get; set; }

        [BitfinexProperty(17)]
        public bool Hidden { get; set; }

        [BitfinexProperty(18)]
        internal string PlaceHolder6 { get; set; }

        [BitfinexProperty(19)]
        public bool Renew { get; set; }

        [BitfinexProperty(20)]
        public decimal RateReal { get; set; }
    }
}
