using System;

namespace MultidimensionalArraysLooping{
    class MultidimensionalArray{
        static void Main(string[] args){

            int[,] multarr = {{1,2,3},{4,5,6},{7,8,9}};

            for(int i = 0; i<multarr.GetLength(0);i++){
                for(int j = 0; j<multarr.GetLength(1);j++){
                    Console.Write(multarr[i,j] + " ");
                }
                Console.WriteLine(); //new line at each row 
            }
        }
    }
}