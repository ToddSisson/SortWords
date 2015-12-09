using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordList = new string[10];
            Console.WriteLine("Enter up to 10 words, one at a time (Enter '0' to stop):");
            for (int x = 0; x < wordList.Length; ++x)
            {
                wordList[x] = Console.ReadLine();
                if (wordList[x] == "0")
                {
                    Array.Resize(ref wordList, x);
                    x = wordList.Length;
                }
            }
            Console.WriteLine();
            Sort(wordList);
        }
        static void Sort(params string[] words)
        {
            Array.Sort(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
