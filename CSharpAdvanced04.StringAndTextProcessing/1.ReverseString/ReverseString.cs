﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray().Reverse();
            Console.WriteLine(String.Join("",input));
        }
    }
}
