using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CategorizeNumbers
{
    static void Main()
    {
        string[] inputNums = Console.ReadLine().Split(' ').ToArray();
        List<int> roundNums = new List<int>();
        List<double> nonRoundedNums = new List<double>();

        for (int i = 0; i < inputNums.Length; i++)
        {
            double currentNum = double.Parse(inputNums[i]);
            int intPartOfNum = (int) currentNum;
            double fractionPartOfNum = currentNum - intPartOfNum;
            if (fractionPartOfNum != 0)
            {
                nonRoundedNums.Add(currentNum);
            }
            else
            {
                roundNums.Add(intPartOfNum);
            }
        }
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", string.Join(", ", nonRoundedNums), nonRoundedNums.Min(),
                                                                              nonRoundedNums.Max(), nonRoundedNums.Sum(), nonRoundedNums.Average());

        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}",string.Join(", ",roundNums),roundNums.Min(),
                                                                              roundNums.Max(),roundNums.Sum(),roundNums.Average());
        
    }
}

