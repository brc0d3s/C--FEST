using System;

public class PropertiesExample{


    private string name;

    public string Name{
        get{
            return name;
        }
        set{
            name = value;
        }
    } 
}


class TestPropertiseExample{
    public static void Main(string[] args){
        PropertiesExample ex= new PropertiesExample();
        ex.Name = "brc0d3s";
        Console.WriteLine($"Employee Name : {ex.Name}");
    }
}