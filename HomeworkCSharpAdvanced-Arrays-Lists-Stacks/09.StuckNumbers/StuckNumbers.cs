using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StuckNumbers
{
    class StuckNumbers
    {
        static void Main()
        {
            int countNumbers = int.Parse(Console.ReadLine());
            string[] inputNums = Console.ReadLine().Split(' ');
            bool isExist = false;
            for (int a = 0; a < countNumbers; a++)
            {
                for (int b = 0; b < countNumbers; b++)
                {
                    for (int c = 0; c < countNumbers; c++)
                    {
                        for (int d = 0; d < countNumbers; d++)
                        {
                            bool numbersIsNotEqual = inputNums[a] != inputNums[b] && inputNums[a] != inputNums[c] &&
                                                     inputNums[a] != inputNums[d] &&
                                                     inputNums[b] != inputNums[c] && inputNums[b] != inputNums[d] &&
                                                     inputNums[c] != inputNums[d];
                            if (numbersIsNotEqual)
                            {
                                string leftString = "" + inputNums[a] + inputNums[b];
                                string rightString = "" + inputNums[c] + inputNums[d];
                                if (leftString.Equals(rightString))
                                {
                                    isExist = true;
                                    Console.WriteLine("{0}|{1}=={2}|{3}", inputNums[a], inputNums[b], inputNums[c],
                                        inputNums[d]);
                                }
                            }
                        }
                    }
                }
            }
            if (!isExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
