using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MyException : Exception
    {
        public string MyMessage { get; private set; }
        public MyException(string message) : base(message)
        {
            MyMessage = message;
        }
    }
}
