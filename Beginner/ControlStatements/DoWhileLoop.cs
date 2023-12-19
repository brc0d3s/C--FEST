using System;

namespace OddCheckerApplication{
    class OddChecker{
        static void Main(string[] args){

            int i = 1;

            do{
                if(i % 2 != 0){
                    Console.WriteLine(i);
                }
                i++;
            } while(i <= 50);
        }
    }
}