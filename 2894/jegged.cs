using System;
class Jegged
{
    static void Main()
    {
        int[][] j = new int[Convert.ToInt32(Console.ReadLine())][];

		for (int i = 0; i < j.Length; i++)
        {
			j[i] =new int[Convert.ToInt32(Console.ReadLine())];
		}

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
