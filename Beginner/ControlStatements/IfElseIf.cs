using System;

namespace GradingSystemApplication{
    class GradingSystem{
        static void Main(String[] args){

            // Student Details
            Console.WriteLine("Student No. :");
            string student_no = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Unit Code : ");
            string unit_code = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Unit Title : ");
            string unit_name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cat Mark : ");
            int cat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Exam : ");
            int main_exam = Convert.ToInt32(Console.ReadLine());

            int total = cat + main_exam;

            char grade = ' ';

            if(total < 0 || total > 100){
                Console.WriteLine("Must be between 0 - 100 ");
                return;
            } else if(0 <= total && total <= 39){
                grade = 'F';
            } else if(40 <= total && total <= 49){
                grade = 'D';
            } else if(50 <= total && total <= 59){
                grade = 'C';
            } else if(60 <= total && total <= 69){
                grade = 'B';
            } else if(70 <= total && total <= 100){
                grade = 'A';
            } else {
                Console.WriteLine("INVALID! Not an Integer Value");
                return;
            }


            Console.WriteLine("\n\n\n--- Display results ---");
            Console.WriteLine("Student No. : {0}",student_no);
            Console.WriteLine("Unit Code : {0}",unit_code);
            Console.WriteLine("Unit Title : {0}",unit_name);
            Console.WriteLine("Cat Mark : {0}",cat);
            Console.WriteLine("Main Exam : {0}",main_exam);
            Console.WriteLine("Total marks : {0}",total);
            Console.WriteLine("Grade : {0}",grade);
            Console.ReadKey();
        }
    }
}