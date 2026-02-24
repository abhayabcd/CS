using System;

class userarray
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter columns: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] a = new int[r, c];
        bool[,] visited = new bool[r, c];

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("a[{0},{1}] = ", i, j);
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine("\nArray Elements:");
        for (int i = 0; i < a.GetLength(0); i++)
		{
			for (int j = 0; j < a.GetLength(1); j++)
			{
				Console.Write("a[{0},{1}] = {2}  ", i, j, a[i, j]);
			}
			Console.WriteLine();
		}
    }
}

