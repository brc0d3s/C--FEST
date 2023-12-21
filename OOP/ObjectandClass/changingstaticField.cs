using System; 

namespace AccountDetailsApplication{
    public class Account  
    {  
        public int accno;   
        public String name;  
        public static float rateOfInterest=8.8f;  
        
        public Account(int accno, String name){  
            this.accno = accno;  
            this.name = name;  
        }  
          
        public void display(){  
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);  
        }  
   }  
   class TestAccount{  
       public static void Main(string[] args)  {  
            // change
            Account.rateOfInterest= 10.5f;

            Account a1 = new Account(101, "Brian");  
            Account a2 = new Account(102, "Omondi");  
            a1.display();  
            a2.display();  
  
        }  
    }  
}