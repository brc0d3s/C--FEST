using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROGRAMS
{
    public class Even
    {
        public static void Main(String[] args){
            
            int count = 0;
            int sum = 0;
            double avg;

            for (int num = 0; num <= 100; num++){
               if(num % 2 == 0){
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