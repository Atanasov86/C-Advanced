using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            Dictionary<string,string> phonebook = new Dictionary<string, string>();
            string inputPhonenumbers = Console.ReadLine();
            while (inputPhonenumbers != "search")
            {
                string[] phonenumbersAsArray = inputPhonenumbers.Split(new char[] {'-'},
                    StringSplitOptions.RemoveEmptyEntries);
                phonebook.Add(phonenumbersAsArray[0],phonenumbersAsArray[1]);
                inputPhonenumbers = Console.ReadLine();
            }
            string searchingName = Console.ReadLine();
            while (inputPhonenumbers != String.Empty)
            {
                if (phonebook.ContainsKey(searchingName))
                {
                    string name = searchingName;
                    string phone = phonebook[searchingName];
                    Console.WriteLine("{0} -> {1}",name,phone);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.",searchingName);
                }
                searchingName = Console.ReadLine();
                inputPhonenumbers = searchingName;
            }
        }
    }
}
