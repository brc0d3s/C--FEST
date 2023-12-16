using System;

namespace IfElseConditionApplication{
    class IfElseCondition{
        static void Main(string[] args){
            Console.WriteLine("Enter the Number :");
            int value = Convert.ToInt32(Console.ReadLine());

            if(value % 2 != 0){
                Console.WriteLine("{0} is Odd number",value);
            } else{
                Console.WriteLine("{0} is Even Number",value);
            }
        }
    }
}