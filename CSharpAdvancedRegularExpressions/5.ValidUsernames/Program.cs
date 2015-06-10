using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string userNames = Console.ReadLine();
            string[] userNamesArr = userNames.Split(new[] {' ', '/', '\\', '(', ')'});
            List<string> validUsernames = new List<string>();
            string pattern = @"\b[a-zA-Z]\w{2,24}\b";
            Regex usernameRegex = new Regex(pattern);
            foreach (var username in userNamesArr)
            {
                bool isMatched = usernameRegex.IsMatch(username);
                if (isMatched)
                {
                    validUsernames.Add(username);
                }
            }
            int maxLength = 0;
            int index = -1;
            for (int i = 0; i < validUsernames.Count - 1; i+=1)
            {
                int length = validUsernames[i].Length + validUsernames[i + 1].Length;
                if (length > maxLength)
                {
                    maxLength = length;
                    index = i;
                }
            }
            Console.WriteLine(validUsernames[index]);
            Console.WriteLine(validUsernames[index + 1]);
        }
    }
}
