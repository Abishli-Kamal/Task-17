using System;
using System.Collections.Generic;
using System.Text;

namespace Task_a
{
    internal class Azerbaijan:Country
    {
        public string Oil;

        public Azerbaijan(string oil, string money, string city, string flag):base(money,city,flag)
        {
            Oil = oil;
        }

        public override void Info()
        {
            Console.WriteLine($"Oil:{Oil} Money:{Money} City:{City} Flag:{Flag} ");
        }
    }
}
