using System;

namespace NestedCounterApplication{
    class NestedCounter{
        static void Main(string[] args){

            for(int i = 1;i <= 5; i++){
                for(int j = 1; j <= 5; j++){
                    Console.WriteLine(i + " " + j);
                }
            }
        }
    }
}