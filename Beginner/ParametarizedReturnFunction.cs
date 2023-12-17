using System;

namespace ParametarizedReturnFunction{
    class ParametarizedReturn{

        public string Show(string message){  
         Console.WriteLine("Inside Show Function");  
         return message;  
        }  

        // Main function, execution entry point of the program  
        static void Main(string[] args){  
            ParametarizedReturn program = new ParametarizedReturn();  
            string message = program.Show("Cypher Wine");  
            Console.WriteLine("Hello "+message);  
        }  
    }
}