using System;

namespace NonParametarizedFunction{
    class NonParametarized{

        public void Show(){
            Console.WriteLine("This is a nonparametarized function");
        }

        static void Main(string[] args){
            NonParametarized par = new NonParametarized();
            par.Show();
        }
    }
}