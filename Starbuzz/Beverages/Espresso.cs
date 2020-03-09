using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class Espresso : IBeverage
    {
        public string Description { get; set; } = "Espresso";
        double IBeverage.Cost { get; } = 1.99;
    }
}
