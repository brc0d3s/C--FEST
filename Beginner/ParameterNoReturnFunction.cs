using System;

namespace ParametarizedNoReturnFunction{
    class ParametarizedNoReturn{

        public void NameDisplay(string name){
            Console.WriteLine("Your name is : {0}",name);
        }

        static void Main(string[] args){
            ParametarizedNoReturn noret = new ParametarizedNoReturn();
            noret.NameDisplay("Brian");
        }
    }
}