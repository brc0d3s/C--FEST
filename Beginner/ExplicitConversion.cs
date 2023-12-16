using System;

namespace ExplicitConversionApplication{
    class ExplicitConversion{
        static void Main(string[] args){
            double d = 234.65763;
            int i;

            //cast double to int
            i=(int)d;
            Console.WriteLine("The integer is : {0}",i);
            Console.ReadKey();

        }
    }
}