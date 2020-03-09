using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public class Decaf : IBeverage
    {
        public string Description { get; set; } = "Decaf Coffee";
        public double Cost { get; set; } = 1.05;
    }
}
