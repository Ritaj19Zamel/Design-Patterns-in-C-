﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;
        private CurrencyConverter()
        {
            LoadExchangeRate();
        }
        private static object _lock = new();
        private static CurrencyConverter _instance;
        public static CurrencyConverter Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ();
                        }
                    }
                }
                
                return _instance;
            }
        }
        private void LoadExchangeRate()
        {
            Thread.Sleep(3000);

            _exchangeRates = new[]
            {
                    new ExchangeRate("USD", "SAR", 3.75m),
                    new ExchangeRate("USD", "EGP", 30.60m),
                    new ExchangeRate("SAR", "EGP", 8.16m)
            };

        }
        public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
        {
            var exchangeRate = _exchangeRates.FirstOrDefault(rate => rate.BaseCurrency == baseCurrency && rate.TargetCurrency == targetCurrency);
            return amount * exchangeRate.Rate;
        }

       

    }
}
