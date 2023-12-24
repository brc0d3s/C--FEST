using System;

namespace DevTownPayrol{
    public class Employees{
        public float salary = 30000;
    }

    public class Programmer:Employees{
        public float bonus = 5000;
    }

    
    class ReturnSalary{
        public static void Main(string[] args){
            Programmer p = new Programmer();
            Console.WriteLine($"Basic Salary = {p.salary}");
            Console.WriteLine($"Programmers Bonus = {p.bonus}");
            Console.WriteLine($"Programmers Salary = {p.bonus+p.salary}");
        }
    }
}