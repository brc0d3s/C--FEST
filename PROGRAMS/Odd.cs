using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROGRAMS
{
    public class Odd
    {
        public static void Main(String[] args){

        double avg = 0;
        int sum = 0;
        int count = 0;
        int num = 0;
        
       
        while(num <= 100){
            if(num % 2 != 0){
                Console.WriteLine(num);
                sum += num;
                count++;
             }
             num++;
        }
        
  
        
        avg = sum/count;
        Console.WriteLine($"SUM : {sum}");
        Console.WriteLine($"AVERAGE : {avg}");  
        }
    }
}