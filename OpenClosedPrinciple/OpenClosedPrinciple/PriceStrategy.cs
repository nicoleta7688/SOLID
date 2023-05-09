﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public abstract class PriceStrategy
    {
        public abstract decimal CalculatePrice(List<FoodItem> menu);
    }
}
