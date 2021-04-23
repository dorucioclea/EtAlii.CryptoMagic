﻿namespace EtAlii.BinanceMagic
{
    using System;

    public record Settings
    {
        public string TransactionsFile { get; init; }  = "Transactions.txt";
        
        public string[] AllowedCoins { get; init; }  = { "BTC", "BNB" }; // "ETH"

        public string ApiKey  { get; init; } = "tLLXzKjw2rmhbJeGZlGSEwWUzrKesTzlPNZphZLueMaaPzzaO7A7LYEszaC6QE4f";
        public string SecretKey  { get; init; } = "10Mr5QAxuEAcXGdtl10pKqHBx5HrsJcd5fdNbXN08gpjL8tFh7Vml2pEm2TVFtmd";

        public string ReferenceCoin  { get; init; } = "BUSD";
        
        public decimal MinimalIncrease  { get; init; } = 0.1m;

        public decimal InitialPurchase  { get; init; } = 5.00000001m; // in BUSD.
        public decimal InitialTargetProfit  { get; init; } = 5.00000001m; // in BUSD.

        public TimeSpan SampleInterval  { get; init; } = TimeSpan.FromMinutes(5);

    }
}