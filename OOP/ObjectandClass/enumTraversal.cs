using System;  


// traversing all values using getNames()

public class EnumExample{  
    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };  
  
    public static void Main(){  
        foreach (string s in Enum.GetNames(typeof(Days))){  
            Console.WriteLine(s);  
        }  
    }  
}  