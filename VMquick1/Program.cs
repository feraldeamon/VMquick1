using System;
using System.Collections.Generic;

namespace VMquick1
{
    class Program
    {
        private static List<String> code = new List<String>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadFile("Test.txt");
            Register e1 = new Register(1, "EAX", 32);
            e1.printRegisterInformation();
            Register e2 = new Register(2, "EBX", 256);
            e2.printRegisterInformation();
        }

        public static void ReadFile(String FileName)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\David\Source\Repos\VMquick1\VMquick1\Test\Test1.txt");
            String line;
            while((line = file.ReadLine()) != null)
            {
                code.Add(line);
                System.Console.WriteLine(line);
            }

        }
    }
}
