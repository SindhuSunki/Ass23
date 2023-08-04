﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public static class MyUtility
    {
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
