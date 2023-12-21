using System;

public enum months{AUG=8,OCT=10,NOV,DEC}

class PrintEnum{
    public static void Main(string[] args){
        int x = (int)months.AUG;
        int y = (int)months.OCT;
        int z = (int)months.DEC;

        Console.WriteLine("AUG: {0}, OCT: {1}, DEC: {2}", x, y, z);
    }
}