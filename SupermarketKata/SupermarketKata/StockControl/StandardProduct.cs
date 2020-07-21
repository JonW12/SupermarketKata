using SupermarketKata.StockControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata
{
    class StandardProduct : Product
    {
        public StandardProduct(string name, double price)
        {
            SetName(name);
            SetPrice(price);
            SetUnit("single");
        }
    }
}
