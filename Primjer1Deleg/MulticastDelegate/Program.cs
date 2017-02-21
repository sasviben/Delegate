using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int SampleDelegete();

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegete del = new SampleDelegete(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateReturnedValue = del();

            Console.WriteLine("DelegateReturnedValue = {0}", DelegateReturnedValue);
        }
        public static int SampleMethodOne()
        {
            return 1;
        }
        public static int SampleMethodTwo()
        {
            return 2;
        }
       
    }
}
