using System;

namespace SingleDArrayTraversalWithForLoop{
    class SingleDArray{
        static void Main(string[] args){

            int[] arr = {23,45,5365,6,92}; //Declaration and Initialization of array  


            //traversing array  
            for(int i = 0;i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }
    }
}