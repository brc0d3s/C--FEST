using System;

public class Account
{
    public int id;
    public String name;
    public static float rateOfInterest;

    // Static constructor to initialize rateOfInterest
    static Account(){
        rateOfInterest = 9.5f;
    }

    // Non-static constructor to initialize id and name
    public Account(int id, String name){
        this.id = id;
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine(id + " " + name + " " + rateOfInterest);
    }
}

class TestEmployee
{
    public static void Main(string[] args){
        Account a1 = new Account(101, "virgy");
        Account a2 = new Account(102, "Lucky");
        a1.Display();
        a2.Display();
    }
}
