using System;
using System.Collections.Generic;
using System.Text;

namespace Starbuzz
{
    public interface IBeverage
    {
        public string Description { get; }
        public double Cost { get; }
    }
}
