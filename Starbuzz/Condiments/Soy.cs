using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz.Condiments
{
    public class Soy : ICondimentDecorator
    {
        public IBeverage Beverage { get; set; }
        public string Description { get => Beverage.Description + ", Soy"; }
        double IBeverage.Cost { get => Beverage.Cost + 0.15; }
        public Soy(IBeverage beverage)
        {
            Beverage = beverage;
        }
    }
}
