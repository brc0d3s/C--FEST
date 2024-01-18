/*
Program Question: Grade Calculator

Write a C# program that takes a student's score as input and calculates the corresponding grade
based on the following grading scale:

A: 90-100
B: 80-89
C: 70-79
D: 60-69
F: 0-59
The program should prompt the user to enter a score and then output the corresponding grade. 
Make sure to handle invalid input, such as a score less than 0 or greater than 100.

*/

using System;

namespace Grade_calc{
    public class Grade_Calculator{
        public static void Main(String[] args){

        double marks;
        char grade = ' ';


        Console.Write("Enter marks [0-100] : ");
        marks = Convert.ToDouble(Console.ReadLine());

        while (marks < 0 || marks > 100){
            Console.WriteLine("Invalid Input!");
            Console.WriteLine("Please Re-enter marks [0-100]: ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        if (marks >= 90 && marks <= 100){
            grade='A';  
        } else if (marks >= 80 && marks <= 89){
            grade='B';
        } else if (marks >= 70 && marks <= 79){
            grade='C';
        } else if (marks >= 60 && marks <= 69){
            grade='D';
        } else{
            grade='F';
        } 
      

        Console.WriteLine($"\nYour Marks is :{marks}");
        Console.WriteLine($"Your Grade is :{grade}");


        }
    }
}