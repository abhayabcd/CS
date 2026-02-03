using System;
class Jegged
{
    static void Main()
    {
        int[][] j = new int[4][];

        j[0] = new int[4];
        j[1] = new int[1];
        j[2] = new int[3];
        j[3] = new int[2];

        for (int i = 0; i < j.Length; i++)
        {
            for (int k = 0; k < j[i].Length; k++)
            {
                j[i][k] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nJagged Array Elements:");
        for (int i = 0; i < j.Length; i++)
        {
            for (int k = 0; k < j[i].Length; k++)
            {
                Console.WriteLine(j[i][k]);
            }
        }
    }
}
