using System;
using System.Collections.Generic;
using System.Text;

namespace Task_a
{
    internal abstract class Country
    {
        public string Money;
        public string City;
        public string  Flag ;


        public Country(string money,string city,string flag)
        {
            Money = money;
            City = city;    
            Flag = flag;   
        }

        public abstract void Info();
    }
}
