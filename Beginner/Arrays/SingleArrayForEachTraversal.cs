using System;

namespace SingleDArrayTraversalWithForEachLoop{
    class SingleDArrayForEach{
        static void Main(string[] args){

            int[] arr = {100,45,76,12,4};


            foreach(int i in arr){
                Console.WriteLine(i);
            }
        }
    }
}