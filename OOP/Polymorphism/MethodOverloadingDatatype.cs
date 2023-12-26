using System;

public class MethodOverloadingDatatype{

    static int Add(int a,int b){
        return a+b;
    }

    static float Add(float a,float b,int c){
        return a+b+c;
    }

    public static void Main(string[] args){
       Console.WriteLine(Add(10,45));
       Console.WriteLine(Add(45.1f,8.7f,10));
    }
}