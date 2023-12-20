using System;

namespace DefaultConstructor{
    public class DefaultConstruct{
        public DefaultConstruct(){
            Console.WriteLine("Default constaructor");
        }


        static void Main(string[] args){
            DefaultConstruct defau = new DefaultConstruct();
            DefaultConstruct d = new DefaultConstruct();
        }

    }
}