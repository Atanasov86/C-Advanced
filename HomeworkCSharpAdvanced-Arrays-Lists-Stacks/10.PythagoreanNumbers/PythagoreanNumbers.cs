using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PythagoreanNumbers
{
    class PythagoreanNumbers
    {
        static List<string> CalculatePythagoreanNumbers(List<int> numbers)
        {
            string result = String.Empty;
            List<string> resultList = new List<string>();
            for (int a = 0; a < numbers.Count; a++)
            {
                for (int b = 0; b < numbers.Count; b++)
                {
                    for (int c = 0; c < numbers.Count; c++)
                    {
                        if ((numbers[a] <= numbers[b]) && (numbers[a]*numbers[a] + numbers[b]*numbers[b] == numbers[c]*numbers[c]))
                        {
                            result = numbers[a] + "*" + numbers[a] + " + " + numbers[b] + "*"
                                    + numbers[b] + " = " + numbers[c] + "*" + numbers[c];
                            resultList.Add(result);
                        }
                    }
                }
            }
            return resultList;
        }
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            List<int> inputNumbers = new List<int>();
            List<string> result = new List<string>();
            inputNumbers.Sort();
            for (int i = 0; i < countOfNumbers; i++)
            {
                inputNumbers.Add(int.Parse(Console.ReadLine()));
            }
            result = CalculatePythagoreanNumbers(inputNumbers);
            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
