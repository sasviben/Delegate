using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void SampleDelegete(out int Integer);

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDelegete del = new SampleDelegete(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateOutputParameterValue = -1;

            del(out DelegateOutputParameterValue);

            Console.WriteLine("DelegateOutputParameterValue = {0}", DelegateOutputParameterValue);
        }
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }
       
    }
}
