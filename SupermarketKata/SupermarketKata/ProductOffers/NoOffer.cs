using SupermarketKata.StockControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata.ProductOffer
{
    class NoOffer : IProductOffer
    {
        public double GetSalesPrice(double qty, Product product, string unit)
        {
            return product.GetPrice() * qty;
        }
    }
}
