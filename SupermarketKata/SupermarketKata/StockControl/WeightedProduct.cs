using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata.StockControl
{
    class WeightedProduct : Product
    {
        public WeightedProduct(string name, double price, string unit)
        {
            SetName(name);
            SetPrice(price);
            SetUnit(unit);
        }
    }
}
