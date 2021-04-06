using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
              
            string str = "Hi Ucertify!!!";

               
            string Hi = str.Substring(3, 8);
            Console.WriteLine(Hi);

             
            string Ucertify = str.Substring(3);
            Console.WriteLine(Ucertify);

            Console.ReadKey();
        }
    }
}