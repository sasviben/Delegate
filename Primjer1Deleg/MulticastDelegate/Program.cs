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
            SampleDelegete del1, del2, del3, del4;
            del1 = new SampleDelegete(SampleMethodOne);
            del2 = new SampleDelegete(SampleMethodTwo);
            del3 = new SampleDelegete(SampleMethodThree);

            del4 = del1 + del2 + del3;
            del4();
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
