using System;
using System.Collections.Generic;
using System.Text;

namespace VMquick1
{
    class Token
    {
        public string lexeme { get; }
        private int id;
        public int lineNumber { get; }
        public int itemNumber { get; }
        public int wordCount { get; }

        public Token(string ac, int lnNum, int itNum, int word)
        {
            lexeme = ac;
            lineNumber = lnNum;
            itemNumber = itNum;
            wordCount = word;
        }
    }
}
