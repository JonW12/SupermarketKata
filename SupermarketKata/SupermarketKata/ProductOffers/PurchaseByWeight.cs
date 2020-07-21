using SupermarketKata.StockControl;
using SupermarketKata.WeightUnits;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata.ProductOffers
{
    class PurchaseByWeight : IProductOffer
    {
        MeasurementUnit mu = new MeasurementUnit();

        public double GetSalesPrice(double qty, Product product, string unit)
        {
            double qtyInProductUnit = 0;
            switch(unit)
            {
                case "kg":
                    qtyInProductUnit = mu.ConvertFromKilograms(qty, product.GetUnit());
                    break;
                case "g":
                    qtyInProductUnit = mu.ConvertFromGrams(qty, product.GetUnit());
                    break;
                case "lb":
                    qtyInProductUnit = mu.ConvertFromLBs(qty, product.GetUnit());
                    break;
                case "oz":
                    qtyInProductUnit = mu.ConvertFromOunces(qty, product.GetUnit());
                    break;
            }

            return qtyInProductUnit * product.GetPrice();
        }
    }
}
