using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


class SubsetSum
{
    static void Main()
    {
        int inputSum = int.Parse(Console.ReadLine());
        int[] inputNums = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
        List<int> subsets = new List<int>();
        int numOfSubsets = 1 << inputNums.Length;
        bool isFound = false;
        for (int i = 0; i < numOfSubsets; i++)
        {
            int position = inputNums.Length - 1;
            int bitMask = i;
            while (bitMask > 0)
            {
                if ((bitMask & 1) == 1)
                {
                    subsets.Add(inputNums.ElementAt<int>(position));
                }
                bitMask >>= 1;
                position--;
                
            }
            if ((subsets.Sum() == inputSum))
            {
                isFound = true;
                Console.WriteLine(string.Join(" + ", subsets) + " = {0}", inputSum);
            }
        }
        if (isFound)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}

