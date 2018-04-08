using System;
using System.Collections.Generic;

namespace VMquick1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CodeBase code = new CodeBase();
            code.ReadFile("Test.txt");
            Register e1 = new Register(1, "EAX", 32);
            e1.printRegisterInformation();
            Register e2 = new Register(2, "EBX", 256);
            e2.printRegisterInformation();
        }

        
    }
}
