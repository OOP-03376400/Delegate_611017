using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    delegate void Mydelegate(string v);

    class Program
    {

        static void Main(string[] args)
        {
            Mydelegate mydel = new Mydelegate(Print);
            mydel += Print;

            Print("Hello World.");
            mydel("Hello Mars");
        }

        static void Print(string v)
        {
            Console.WriteLine(v);    
        }

    }
}
