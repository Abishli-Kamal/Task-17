using System;
using System.Collections.Generic;
using System.Text;

namespace Task_a
{
    internal class Norway : Country
    {
        public string TacoFriday;

        public Norway(string tacoFriday, string money, string city, string flag) : base(money, city, flag)
        {
            TacoFriday = tacoFriday;

        }
        public override void Info()
        {
            Console.WriteLine($"TacoFriday:{TacoFriday} Money:{Money} City:{City} Flag:{Flag}");
        }

    }
}

