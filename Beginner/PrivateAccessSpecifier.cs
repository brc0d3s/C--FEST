using System;

namespace PrivateAccesModifier{
    class AreaOfCircle{

        private double radius;
        private const double PI = 3.14;

        public void GetRadius(){
            Console.WriteLine("Enter the radius : ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea(){
            return PI * Math.Pow(radius,2);
        }

        public void Display(){
            Console.WriteLine("The radius is : {0}",radius);
            Console.WriteLine("The Area is : {0}",GetArea());
        }
    }


    class GetAreaOfTheCircle{
        static void Main(string[] args){
            AreaOfCircle ar = new AreaOfCircle();
            ar.GetRadius();
            ar.Display();
        }

    }
}