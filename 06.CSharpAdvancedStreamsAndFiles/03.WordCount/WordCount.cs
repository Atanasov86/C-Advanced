using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WordCount
{
    class WordCount
    {
        static void Main()
        {
            StreamReader wordReader = new StreamReader("../../word.txt");
            StreamReader textReader = new StreamReader("../../text.txt");
            StreamWriter resultWriter = new StreamWriter("../../result.txt");
            Dictionary<string,int> result = new Dictionary<string, int>();
            List<string> wordsList = new List<string>();
            using (wordReader)
            {
                using (textReader)
                {
                    wordsList = textReader.ReadToEnd().Split(new[] { ' ', '-', '.', ',', '?', '!', '\r', '\n', '…' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    while (true)
                    {
                        string currentWord = wordReader.ReadLine();
                        if (currentWord == null)
                        {
                            break;
                        }
                        
                        int count = 0;
                        for (int i = 0; i < wordsList.Count; i++)
                        {
                            string currentListElement = wordsList[i].ToLower();
                            if (currentListElement.Equals(currentWord))
                            {
                                count++;
                            }
                        }
                        result.Add(currentWord,count);
                    }
                    result = result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    using (resultWriter)
                    {
                        foreach (var word in result)
                        {
                            resultWriter.WriteLine("{0} - {1}",word.Key,word.Value);
                        }
                    }
                }
                
            }
        }
    }
}
