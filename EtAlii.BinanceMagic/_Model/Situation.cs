﻿namespace EtAlii.BinanceMagic
{
    public record Situation
    {
        public decimal SourceSellFee { get; init; }
        public decimal DestinationBuyFee { get; init; }
        
        public Delta Source { get; init; }
        public Delta Destination { get; init; }
        
        public bool IsInitialCycle { get; init; }
    }
}