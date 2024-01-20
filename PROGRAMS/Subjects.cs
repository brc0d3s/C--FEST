using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROGRAMS
{
    public class Subjects
    {
        public static void Main(String[] args){

            int sum = 0;
            int avg = 0;
            int Subjects = 10;
            int marks;

            do
            {
                Console.WriteLine("Enter Marks for 10 units : ");
                marks = Convert.ToInt32(Console.WriteLine());

                sum += marks;
            } while (Subjects <= 10);


        }
    }
}