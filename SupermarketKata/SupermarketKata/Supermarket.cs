using SupermarketKata.ProductOffer;
using SupermarketKata.StockControl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;

namespace SupermarketKata
{
    public class Supermarket
    {
        private static Supermarket sm = new Supermarket();
        StockControl.StockControl[] StockRoom = new StockControl.StockControl[10];

        private Supermarket()
        {
            SetUpStore();
        }

        public static Supermarket GetInstance()
        {
            sm.StockRoom = SetUpStore();
            return sm;
        }

        private static StockControl.StockControl[] SetUpStore()
        {
            StockControl.StockControl[] sr = new StockControl.StockControl[10];
            Product product = new StandardProduct("Tin of Beans", 0.65);
            SupermarketKata.StockControl.StockControl sc = new StockControl.StockControl(product, 50, "No Offer");
            sr[0] = sc;

            product = new StandardProduct("Crisps", 0.40);
            sc = new StockControl.StockControl(product, 100, "3ForAPound");
            sr[1] = sc;

            product = new StandardProduct("Soap", 2.50);
            sc = new StockControl.StockControl(product, 40, "Buy 2 get 1 Free");
            sr[2] = sc;

            product = new WeightedProduct("Beef", 2, "kg");
            sc = new StockControl.StockControl(product, 40, "Purchase By Weight");
            sr[3] = sc;

            return sr;
        }

        public double PriceSale(string product, double qty, string unit)
        {
            int index = -1;
            for (int i = 0; i < StockRoom.Length; i++)
            {
                if(StockRoom[i].GetProduct().GetName().Equals(product))
                {
                    index = i;
                    break;
                }
            }

            return StockRoom[index].GetSalePrice(qty, unit);
        }
    }
}
