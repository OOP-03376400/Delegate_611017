using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    delegate int MyDel(int x);

    class Program
    {

        static void Main(string[] args)
        {
            //1. old fasion
            MyDel incdel = new MyDel(Increment);
            // anonmous method
            MyDel incdel1= delegate (int x) { return x + 1; };

            // Lambda Expression
            MyDel Le1 = (int x) => { return x + 1; };
            MyDel Le2 = x => { return x + 1; };
            MyDel Le3 = x => x + 1; 

            int i = Le3(2);
            Console.WriteLine(i);
        }

        static int Increment(int x)
        {
            return x + 1;
        }

    }
}
