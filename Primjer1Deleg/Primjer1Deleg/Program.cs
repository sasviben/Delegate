using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HelloFuntionDelegate(string Message);

namespace Primjer1Deleg
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloFuntionDelegate del = new HelloFuntionDelegate(Hello);//proslijediti ime metode koja mora biti void
            del("Hello from Delegate");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }

}
