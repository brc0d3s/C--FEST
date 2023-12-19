using System;

namespace StudentDetailsParams{
    class StudentDetails{

        // Declare class-level fields
        private string name;
        private string university;
        private string faculty;
        private string department;
        private int studentNo;

        // Method to get data from the user
        public void GetData(){
            Console.WriteLine("Enter Your Name :");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your University :");
            university = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Faculty :");
            faculty = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Department :");
            department = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Your Student No :");
            studentNo = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowDetails(params object [] details){
            foreach(object detail in details){
                Console.WriteLine(detail);
            }
        }


        static void Main(string[] args){
            StudentDetails data = new StudentDetails();
            data.GetData();
            data.ShowDetails("\n\n\nName : " + data.name,"University : "+data.university,"Faculty : "+data.faculty,"Department : "+data.department,"Student No : "+ data.studentNo);
        }
    }
}