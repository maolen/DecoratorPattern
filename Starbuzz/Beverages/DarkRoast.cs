using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class DarkRoast : IBeverage
    {
        public string Description { get; set; } = "Dark Roast Coffee";

        public double Cost { get; set; } = 0.99;
    }
}
