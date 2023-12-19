using System;

namespace PublicAccesModifierApplication{
    class PerimeterOfRectangle{

        public double length;
        public double width;

        public double GetPerimeter(){
            double getresult = length + width;
            return 2 * getresult;
        }

        public void Display(){
            Console.WriteLine("The Length is : {0}", length);
            Console.WriteLine("The Width is : {0}", width);
            Console.WriteLine("The Perimeter is : {0}", GetPerimeter());
        }
    }


    class PublicAccesModifier{
        static void Main(string[] args){

            PerimeterOfRectangle per = new PerimeterOfRectangle();
            per.length = 456.56;
            per.width = 4634.7;
            per.Display();
        }
    }
}