using SupermarketKata.StockControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata.ProductOffers
{
    class ThreeForAPound : IProductOffer
    {
        public double GetSalesPrice(double qty, Product product, string unit)
        {
            double notInOffer = qty % 3;
            double price = notInOffer * product.GetPrice();
            double inOffer = qty - notInOffer;
            price += (inOffer / 3);
            return price;
        }
    }
}
