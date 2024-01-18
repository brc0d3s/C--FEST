using System;

namespace PROGRAMS{
    public class Tax_System{
        
        double b_salary;
        int O_hours;
        double overtime_pay;
        double gross_pay;
        double PAYE;
        double net_pay;

        
        public void inputs(){
            Console.Write("Enter basic salary : ");
            b_salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Overtime Hours : ");
            O_hours = Convert.ToInt32(Console.ReadLine());
        }

        
        public void calculateOvertimePay(){
            if (O_hours >= 0 && O_hours <= 5){
                overtime_pay = O_hours * 500.00;
            } 
            else if (O_hours > 5){
                overtime_pay = (5 * 500.00)+(O_hours -5)*650.00;
            }
        }

        
        public void calculatePAYE(){
            gross_pay = b_salary + overtime_pay;

            if (gross_pay > 100000){
                PAYE = 0.3 * gross_pay;
            }
            else if (gross_pay > 30000 && gross_pay <= 100000){
                PAYE = 0.25 * gross_pay;
            }
            else if (gross_pay <= 30000){
                PAYE = 0.15 * gross_pay;
            }
        }

       
        public void display(){
            net_pay = gross_pay - PAYE;

            Console.WriteLine($"\n\nBasic Salary: {b_salary}");
            Console.WriteLine($"Overtime Hours: {O_hours}");
            Console.WriteLine($"Overtime Pay: {overtime_pay}");
            Console.WriteLine($"Gross pay: {gross_pay}");
            Console.WriteLine($"Net Pay: {net_pay}");
        }


        public static void Main(string[] args){
            Tax_System tax = new Tax_System();
            tax.inputs();
            tax.calculateOvertimePay();
            tax.calculatePAYE();
            tax.display();
        }
    }
}
