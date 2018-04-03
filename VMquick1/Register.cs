using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VMquick1
{
    class Register
    {
        int RegisterID;
        String RegisterName;
        String RegisterLiteral;
        int RegisterSize;
        byte[] Storage;
        int RegisterValue;

        public Register(int id, String name, int val)
        {
            RegisterID = id;
            RegisterName = name;
            setValue(val);

        }

        public void setValue(int val)
        {
            RegisterValue = val;
            Storage = BitConverter.GetBytes(RegisterValue);
            Array.Reverse(Storage);
        }

        public String printRegisterStorage()
        {
            String s = string.Join(" ", Storage.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
            return s;
        }

        public void printRegisterInformation()
        {
            System.Console.WriteLine("Register Name: {0}", RegisterName);
            System.Console.WriteLine("Register Literal {0}", RegisterLiteral);
            System.Console.WriteLine("Register Value: {0}", RegisterValue);
            System.Console.WriteLine("Register Storage: {0}", printRegisterStorage());
        }
    }
}
