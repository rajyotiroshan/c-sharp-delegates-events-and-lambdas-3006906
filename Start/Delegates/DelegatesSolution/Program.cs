using System;

namespace DelegatesSolution
{
    public delegate int ShippingCharge(string zone);
    class Program
    {
        static void Main(string[] args)
        {
            

         while("exit" != Console.ReadLine()){
            string zoneName =Console.ReadLine();
            Console.WriteLine(zoneName);
         }
        }
    }
}
