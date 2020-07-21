using SupermarketKata.ProductOffer;
using SupermarketKata.ProductOffers;
using System;

namespace SupermarketKata.StockControl
{
    class StockControl
    {
        Product product;
        int quantity;
        IProductOffer offer;


        public StockControl(Product product, int quantity, String offer)
        {
            this.product = product;
            this.quantity = quantity;
            this.offer = ApplyOffer(offer);
        }

        public IProductOffer ApplyOffer(String offer)
        {
            switch(offer)
            {
                case "No Offer":
                    return new NoOffer();
                case "3ForAPound":
                    return new ThreeForAPound();
                case "Buy 2 get 1 Free":
                    return new BuyTwoGetOneFree();
                case "Purchase By Weight":
                    return new PurchaseByWeight();
            }
            return null;
        }

        public double GetSalePrice(double qty, string unit)
        {
            return offer.GetSalesPrice(qty, product, unit);
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
