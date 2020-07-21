using System;
using System.Collections.Generic;
using System.Text;

namespace SupermarketKata.WeightUnits
{
    class MeasurementUnit
    {
        public double ConvertFromKilograms(double weight, string unit)
        {
            return (unit.ToLower()) switch
            {
                "kg" => weight * 1,
                "g" => weight * 1000,
                "lb" => weight * 2.2,
                "oz" => weight * 35.2,
                _ => 0,
            };
        }

        public double ConvertFromGrams(double weight, string unit)
        {
            return (unit.ToLower()) switch
            {
                "kg" => weight * 0.001,
                "g" => weight * 1,
                "lb" => weight * 0.002,
                "oz" => weight * 0.35,
                _ => 0,
            };
        }
        public double ConvertFromLBs(double weight, string unit)
        {
            return (unit.ToLower()) switch
            {
                "kg" => weight * 0.45,
                "g" => weight * 453,
                "lb" => weight * 1,
                "oz" => weight * 16,
                _ => 0,
            };
        }
        public double ConvertFromOunces(double weight, string unit)
        {
            return (unit.ToLower()) switch
            {
                "kg" => weight * 0.02,
                "g" => weight * 28.34,
                "lb" => weight * 0.06,
                "oz" => weight * 1,
                _ => 0,
            };
        }
    }
}
