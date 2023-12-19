using System;

namespace PassingArrayTofunct{
    class PassingArray{

        public void PrintArray(int[] arr){
            Console.WriteLine("The Elements in Array are :\n");
            foreach(int i in arr){
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args){
            PassingArray passarr = new PassingArray();
            int[] arr1 = {10,20,30,40};
            int[] arr2 = {50,60,70,80};

            passarr.PrintArray(arr1);
            passarr.PrintArray(arr2);
        }
    }
}