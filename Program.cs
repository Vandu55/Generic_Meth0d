using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Meth0d
{
    class Program
    {
        //public static bool Check<T>(T a, T b)
        //{
        //bool c = a.Equals(b);
        // return c;
        // }



        public  static void Check<T>(T a)
        {
            Console.WriteLine(typeof(T));
        }
        class Ex
        {
            static void Main(string[] args)
            {


                Program.Check(78);
                // Console.WriteLine(Program.Check(40, 40));
                //Console.WriteLine(Program.Check("amm","amm"));
                //Console.WriteLine(Program.Check("a","c"));
            }
        }

    }
}