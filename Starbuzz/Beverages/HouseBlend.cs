using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class HouseBlend : IBeverage
    {
        public string Description { get; set; } = "House Blend Coffee";
        public double Cost { get; set; } = 0.89;
    }
}
