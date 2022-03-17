using System;

namespace Task_a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Azerbaijan azerbaijan = new Azerbaijan("Neft", "Manat", "Baku", "Bayraq");
            Norway norway = new Norway("Eat", "Kron", "	Bergen", "Bayraq");

            norway.Info();
            azerbaijan.Info();
           
        }
    }
}
