using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VMquick1
{
    class CodeBase
    {
        private string[] code;
        private List<Token> tokens = new List<Token>();

        public void ReadFile(String FileName)
        {
            code = System.IO.File.ReadAllLines(@"C:\Users\David\Source\Repos\VMquick1\VMquick1\Test\Test1.txt");
            int lnNumber = 1, itNumber = 1, wordCount = 1;
            foreach (string line in code)
            {
                wordCount = 1;
                string[] txt = line.Split(" ");
                foreach (string text in txt)
                {
                    Console.WriteLine("Token: \"{0}\", Line Number: {1}, Word Count: {2}, Item Number: {3}", text, lnNumber, wordCount, itNumber);
                    Token temp = new Token(text, lnNumber, itNumber++, wordCount++);
                    tokens.Add(temp);
                    
                }

                Console.WriteLine(line);
                lnNumber++;
            }

        }
    }
}
