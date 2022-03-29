using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Exception
{
    internal class CapacityLimitException
    {
        public CapacityLimitException(string message) : base(message)
        {
            Console.WriteLine("Limiti dolacaq");
        }
    }
}
