using System;

// Note: C# destructor cannot have parameters. Moreover, modifiers can't be applied on destructors.

namespace ConstructorDestructorExample{
    class ConstructorDestructor{

        public ConstructorDestructor(){
            Console.WriteLine("Constructor Invoked");
        }

        ~ConstructorDestructor(){
            Console.WriteLine("Destructor Invoked");
        }


        public static void Main(string[] args){
            ConstructorDestructor co = new ConstructorDestructor();
            ConstructorDestructor con = new ConstructorDestructor();
        }
    }

}