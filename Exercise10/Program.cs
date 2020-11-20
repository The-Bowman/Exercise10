using System;
using System.IO;

namespace Exercise10
{
    class EndOfWords
    {
        static void Main(string[] args)
        {
            StreamReader file;
            string sentence;
            string[] wordList;
            int total = 0;

            try
            {
                file = File.OpenText("TextFile1.txt");
                sentence = file.ReadLine();
                wordList = sentence.Split(' ');

                foreach (string s in wordList)
                {
                   if (s.EndsWith('t') || s.EndsWith('e'))
                    {
                        total++;
                    }
                }

                Console.WriteLine("There are a total of " + total + " words that end with t or e");
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        
    }
}
