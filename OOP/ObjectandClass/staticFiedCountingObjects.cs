using System;  
   public class Account  
    {  
        public int accno;   
        public String name;  
        public static float rateOfInterest=8.8f;  
        public static int count = 0;
        
        public Account(int accno, String name){  
            this.accno = accno;  
            this.name = name; 

            count++; 
        }  
          
        public void display(){  
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);  
        }  
   }  
   class TestAccount{  
       public static void Main(string[] args)  {  
            // change
            Account.rateOfInterest= 10.5f;
            
            Account a1 = new Account(101, "Sonoo");  
            Account a2 = new Account(102, "Mahesh");  
            a1.display();  
            a2.display();  
  
            Console.WriteLine($"The total number of objects is : {Account.count}");
        }  
    }  