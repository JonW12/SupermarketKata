using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata.StockControl
{
    abstract class Product
    {
        string name;
        double price;
        string unit;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetUnit(string unit)
        {
            this.unit = unit;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public string GetUnit()
        {
            return unit;
        }

        override
        public string ToString()
        {
            return name + " £" + price.ToString();
        }
    }
}
