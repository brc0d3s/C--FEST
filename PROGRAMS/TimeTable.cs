using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROGRAMS
{
    public class TimeTable
    {
        string unit = "";
        string unit_Title = "";
        string lecturer = "";
        string lecture_Hall = "";
        char stream = '\0';
        string day = "";
        string time = "";

        bool isFound = false;


        public void getDetails(){
            Console.Write("Enter the Unit Code [eg CMT 100] : ");
            unit = Convert.ToString(Console.ReadLine().ToUpper());

            Console.Write("Enter Your Stream [A or B] : ");
            stream = Convert.ToChar(Console.ReadLine().ToUpper());
        }



        public void evaluateTimetable(){
            while(!isFound){
                if (unit == "CMT 301" && stream == 'A'){
                unit_Title = "Research Methodology";
                lecturer = "Nicodemus Ishmael";
                lecture_Hall = "Blended 29";
                day = "TUESDAY";
                time = "1400 - 1700HRS";
                isFound = true;
            }
            else if(unit == "CMT 307" && stream == 'A' ){
                unit_Title = ".Net Programming";
                lecturer = "Chris Nandasaba";
                lecture_Hall = "TH Lab A";
                day = "FRIDAY";
                time = "0800 - 1100HRS";
                isFound = true;
            }
            else if(unit == "CMT 311" && stream == 'A' ){
                unit_Title = "Fundamentals of Software Engineering";
                lecturer = "Nicodemus Ishmael";
                lecture_Hall = "Blended 2";
                day = "TUESDAY";
                time = "1100 - 1400HRS";
                isFound = true;
            }
            else if(unit == "CMT 313" && stream == 'A' ){
                unit_Title = "Computer Graphics";
                lecturer = "David Maina";
                lecture_Hall = "TH Lab B";
                day = "THURSDAY";
                time = "0800 - 1100HRS";
                isFound = true;
            }
            else if(unit == "CMT 316" && stream == 'A' ){
                unit_Title = "Human Computer Interface";
                lecturer = "Julias Sirima";
                lecture_Hall = "TH Lab A";
                day = "WEDNESDAY";
                time = "1100 - 1400HRS";
                isFound = true;
            }
            else if(unit == "CMT 317" && stream == 'A' ){
                unit_Title = "Information System Security";
                lecturer = "William Mirugi";
                lecture_Hall = "Blended 29";
                day = "MONDAY";
                time = "1400 - 1700HRS";
                isFound = true;
            }
            else{
                Console.WriteLine("\nNo Matching Data! Try again.\n");
                getDetails();
            }
            }
        }


        public void display(){
            if (isFound){
                Console.WriteLine("\n\n");
                Console.WriteLine($"Unit : {unit}");
                Console.WriteLine($"Unit Title : {unit_Title}");
                Console.WriteLine($"Lecturer : {lecturer}");
                Console.WriteLine($"Lecture Hall : {lecture_Hall}");
                Console.WriteLine($"Stream : {stream}");
                Console.WriteLine($"Day : {day}");
                Console.WriteLine($"Time : {time}");
            }
        }


        public static void Main(String[] args){
            TimeTable time = new TimeTable();
            time.getDetails();
            time.evaluateTimetable();
            time.display();
        }
    }
}