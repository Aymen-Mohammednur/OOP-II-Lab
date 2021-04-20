using System;

namespace C_Sharp_Basic
{
    public class Question60
    {
        public static void a()
        {
            int[][] myMatrix = new int[][] {
                    new int[]{1, 2, 1, 0 },
                    new int[]{0, 5, 0, 0},
                    new int[]{1, 1, 3, 10 } };
            Console.WriteLine(SumOfMatrix(myMatrix));
        }
        public static int SumOfMatrix(int[][] myMatrix)
        {
            int sum = 0;
            for (int i = 0; i < myMatrix[0].Length; i++) {
                for (int j = 0; j < myMatrix.Length && myMatrix[j][i] > 0; j++) {
                    sum += myMatrix[j][i];
                }
            }
            return sum;
        }
    }
}