using SupermarketKata.StockControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata
{
    interface IProductOffer
    {
        public double GetSalesPrice(double qty, Product product, string unit);
    }
}
