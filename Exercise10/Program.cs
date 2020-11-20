using System;
using System.IO;

namespace Exercise10
{
    class EndOfWords
    {
        static void Main(string[] args)
        {
            // initialize variables
            StreamReader file;
            string sentence;
            string[] wordList;
            int total = 0;

            // attempt to open and process file
            try
            {
                file = File.OpenText("TextFile1.txt"); // opens file
                sentence = file.ReadLine();     // reads line
                wordList = sentence.Split(' '); // delimits on spaces, distributes words into an array

                // loops through arrray and checks last char of each word
                foreach (string s in wordList)
                {
                   if (s.EndsWith('t') || s.EndsWith('e'))
                    {
                        total++;    // increment total of words that end with t or e
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
