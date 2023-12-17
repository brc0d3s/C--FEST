/* Only functions of the same class can access its private members. Even an instance of a class cannot 
access its private members.

the member variables length and width are declared private, so they cannot be accessed from the 
function Main(). The member functions AcceptDetails() and Display() can access these variables.
 Since the member functions AcceptDetails() and Display() are declared public, they can be accessed 
 from Main() using an instance of the Rectangle class, named r.
 */

 using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      private double length;
      private double width;
      
      public void Acceptdetails() {
         Console.WriteLine("Enter Length: ");
         length = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter Width: ");
         width = Convert.ToDouble(Console.ReadLine());
      }
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.ReadLine();
      }
   }
}