using System;

namespace VolumeOfCylinderApplication{
    class VolumeOfCylinder{

        const double PI = 3.14;
        double radius;
        double height;

        public void InputValues(){
            Console.WriteLine("Enter the radius : ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height : ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        public double Volume(){
            return PI * Math.Pow(radius,2) * height;
        }

        public void Display(){
            Console.WriteLine("The Radius is : {0}",radius);
            Console.WriteLine("The Height is : {0}",height);
            Console.WriteLine("The Volume is : {0}",Volume());
            Console.ReadLine();
        }

        static void Main(string[] args){
            VolumeOfCylinder vol = new VolumeOfCylinder();
            vol.InputValues();
            vol.Display();
        }

    }
}