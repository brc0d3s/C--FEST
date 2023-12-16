using System;

namespace RectangleApplication{
    class Rectangle{

        // Variables
        double length;
        double width;


        public void acceptDetails(){
            length = 10.5;
            width = 12.7;

        }


        public double getArea(){
            return length * width;
        }


        public void display(){
            Console.WriteLine("Length : {0}",length);
            Console.WriteLine("Width : {0}",width);
            Console.WriteLine("Area : {0}",getArea());
        }


        class ExecuteRectangle{
            static void Main(string[] args){
                Rectangle r= new Rectangle();
                r.acceptDetails();
                r.display();
                Console.ReadLine();
            }
        }
    }
}