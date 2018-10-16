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
            Mydelegate myStaticDel  = Print;
            ClassA classA = new ClassA();
            Mydelegate myObjectDel = classA.Print;

            Mydelegate myAllDel = myStaticDel + myObjectDel;

            Mydelegate Mydel2 = x => Console.WriteLine(x);

            myAllDel("Hello");
            Mydel2("Hello Venus");
        }

        static void Print(string v)
        {
            Console.WriteLine("Print from static method: " + v);
        }

    }

    class ClassA
    {
        public void Print(string v)
        {
            Console.WriteLine("Print from class A: " + v);
        }
    }
}
