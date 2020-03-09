using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz.Condiments
{
    public class Whip : ICondimentDecorator
    {
        public IBeverage Beverage { get; set; }
        public string Description { get => Beverage.Description + ", Whip"; }
        double IBeverage.Cost { get => Beverage.Cost + 0.10; }
        public Whip(IBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
