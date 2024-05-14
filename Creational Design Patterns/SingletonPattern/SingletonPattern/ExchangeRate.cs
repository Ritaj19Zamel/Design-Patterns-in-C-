using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class ExchangeRate
    {
        public ExchangeRate(string baseCurrency, string targetCurrency, decimal rate)
        {
            BaseCurrency = baseCurrency;
            TargetCurrency = targetCurrency;
            Rate = rate;
        }
        public string BaseCurrency { get;}
        public string TargetCurrency { get; }
        public decimal Rate { get; }
    }
}
