using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void SampleDelegete();

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegete del = new SampleDelegete(SampleMethodOne);
            del += SampleMethodTwo;
            del += SampleMethodThree;

            del();
        }
        public static void SampleMethodOne()
        {
            Console.WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo()
        {
            Console.WriteLine("SampleMethodTwo Invoked");
        }
        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }
    }
}
