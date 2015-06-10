using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int count = 1;
        for (int i = 0; i < input.Length - 1; i++)
        {
            string currentStr = input[i];
            if (currentStr.Equals(input[i+1]))
            {
                count++;
            }
            else
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(currentStr + " ");
                }
                Console.WriteLine();
            }
            if (currentStr != input[i + 1])
            {
                count = 1;
            }
        }
        for (int i = 0; i < count; i++)
        {
            Console.Write(input[input.Length - 1] + " ");
        }
        Console.WriteLine();

    }
}

