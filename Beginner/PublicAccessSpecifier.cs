/* Any public member can be accessed from outside the class.

the member variables length and width are declared public, so they can be accessed from the function Main() 
using an instance of the Rectangle class, named r.

The member function Display() and GetArea() can also access these variables directly without using any instance of the class.

The member functions Display() is also declared public, so it can also be accessed from Main() 
using an instance of the Rectangle class, named r.

 */

using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      public double length;
      public double width;
      
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
         r.length = 4.5;
         r.width = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}