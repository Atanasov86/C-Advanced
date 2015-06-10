using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] inputArr = input.Split(' ');
        int[] inputAsNum = Array.ConvertAll(inputArr, s => int.Parse(s));
        Array.Sort(inputAsNum);
        Console.WriteLine(string.Join(" ",inputAsNum));
    }
}

