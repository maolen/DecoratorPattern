using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class Mocha : ICondimentDecorator
    {
        public IBeverage Beverage { get; set; }
        public string Description { get => Beverage.Description + ", Mocha"; }
        double IBeverage.Cost { get => Beverage.Cost + 0.20; }
        public Mocha(IBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
