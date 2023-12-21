using System;

namespace ThisInstaceVariableRefference{
    class StudentClass{

        int studentNo;
        string name;
        char gender;

        double height;

        public StudentClass(int studentNo,string name,char gender,double height){

            // Using 'this' to refer to instance variables
            this.studentNo = studentNo;
            this.name = name;
            this.gender = gender;
            this.height = height;

            Console.WriteLine($"Student no : {studentNo}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Gender : {gender}");
            Console.WriteLine($"Height : {height}");
        }
    }


    class ViewStudent{
        public static void Main(string[] args){
            StudentClass s = new StudentClass(1045858,"Brian Omondi",'M',104.5);
        }
    }
}