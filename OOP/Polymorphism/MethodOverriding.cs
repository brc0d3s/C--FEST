using System;

public class Animals{

    public virtual void Eat(){
        Console.WriteLine("Eating");
    }
}


public class Pig:Animals{
    public override void Eat(){
        Console.WriteLine("Food remains : Omnivore");
    }
}

public class TestOvveride{
    public static void Main(string[] args){
        Pig p = new Pig();
        p.Eat();
    }
}