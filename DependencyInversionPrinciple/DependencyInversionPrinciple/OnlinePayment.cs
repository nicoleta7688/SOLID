﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class OnlinePayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Performing online payment of {0} lei...", amount);
        }
    }
}
