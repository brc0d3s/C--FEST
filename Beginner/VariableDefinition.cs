using System;

namespace VariableDefinitionApplication{
    class VariableDefinition{
        static void Main(string[] args){
            short a;
            int b;
            double c;

            /* Actual Initialization */
            a = 235;
            b = 875;
            c = a % b;

            Console.WriteLine("a = {0} \nb = {0} \nc = {0}",a,b,c);
            Console.ReadKey();

        }
    }
}