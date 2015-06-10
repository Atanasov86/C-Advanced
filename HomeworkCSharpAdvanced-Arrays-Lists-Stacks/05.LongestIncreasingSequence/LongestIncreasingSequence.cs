using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] inputNums = input.Split(' ').Select(int.Parse).ToArray();
        List<string> incresingSequence = new List<string>();
        string sequence = "";
        
        string longestSequence = "";
        for (int i = 0; i < inputNums.Length - 1; i++)
        {
            if (sequence == String.Empty)
            {
                sequence += inputNums[i]+ " ";
            }

            if (inputNums[i] < inputNums[i +1] && i != inputNums.Length - 1)
            {
                sequence += inputNums[i+1] + " ";
            }
            else
            {
                incresingSequence.Add(sequence);
                sequence = String.Empty;
            }

        }
        incresingSequence.Add(sequence);
        foreach (var str in incresingSequence)
        {
            Console.WriteLine(str);
        }

        Console.Write("Longest: ");
        Console.WriteLine(incresingSequence.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur));
    }
}

