using System;

public class MethodOverloadingByArgumets{

    static int Add(int a,int b){
        return a+b;
    }

    static int Add(int a,int b,int c){
        return a+b+c;
    }

    public static void Main(string[] args){
       Console.WriteLine(Add(10,45));
       Console.WriteLine(Add(456,87,10));
    }
}