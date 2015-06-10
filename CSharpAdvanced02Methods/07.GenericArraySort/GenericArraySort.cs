using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _07.GenericArraySort
{
    class GenericArraySort
    {
        public static void SortingMethod<T> (List<T> list) where T : IComparable
        {
            
            bool isSwap = false;
            do
            {
                isSwap = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    
                    if (list[i].CompareTo(list[i+1]) > 0)
                    {
                        T tempElement = list[i];
                        list[i] = list[i+1];
                        list[i+1] = tempElement;
                        isSwap = true;
                    }
                }

            } while (isSwap);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            List<int> number = new List<int> { 1, 3, 4, 5, 1, 0, 5 };
            List<string> words = new List<string> { "zaz", "cba", "baa","azis" };
            List<DateTime> dates = new List<DateTime> { new DateTime(2002, 3, 1),
                                                        new DateTime(2015, 05, 06), new DateTime(2014, 1, 1) };
            SortingMethod(number);
            SortingMethod(words);
            SortingMethod(dates);
        }
    }
}
