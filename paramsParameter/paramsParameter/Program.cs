using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            useParamsObject(1, 2, 3000.56f, 4M, 255, 6D, 7, 8, 9F, 0, "Hello World");
        }

        public static void UseParams(params int[] list)
        {
            Console.WriteLine("size of list is {0}", list.Length);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void useParamsObject(params object[] list)
        {
            Console.WriteLine("size of list is {0}", list.Length);
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }

    }
}
