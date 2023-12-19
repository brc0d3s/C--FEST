using System;

namespace JaggedArraysExample{
    class JaggedArrays{
        static void Main(string[] args){

            int[][] jaggedarr = new int[3][]{
                new int[] {2,1,3,4,5},
                new int[] {5,6,8,9},
                new int[] {4,6,8}
            };

             // Traverse array elements  
             for(int i = 0;i<jaggedarr.Length;i++){
                for(int j = 0;j<jaggedarr[i].Length;j++){
                    Console.Write(jaggedarr[i][j]+ " ");
                }
                Console.WriteLine();
             }

        }
    }
}