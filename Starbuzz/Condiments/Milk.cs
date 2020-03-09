using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz.Condiments
{
    public class Milk : ICondimentDecorator
    {
        public IBeverage Beverage { get; set; }
        public string Description { get => Beverage.Description + ", Milk"; }
        double IBeverage.Cost { get => Beverage.Cost + 0.10; }
        public Milk(IBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
