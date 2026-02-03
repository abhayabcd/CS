using System;
class userarray
{
	static void Main()
	{
		int[,,] a = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
		for (int i = 0; i < a.GetLength(0); i++)
		{
			for (int j = 0; j < a.GetLength(1); j++)
			{
				for (int k = 0; k < a.GetLength(2); k++)
				{
					Console.WriteLine("a[{0},{1},{2}] = ", i, j, k);
					a[i, j, k] = Convert.ToInt32(Console.ReadLine());
				}		
			}
		}
		for (int i = 0; i < a.GetLength(0); i++)
		{
			for (int j = 0; j < a.GetLength(1); j++)
			{
				for (int k = 0; k < a.GetLength(2); k++)
				{
					Console.Write("a[{0},{1},{2}] = {3}  ", i, j, k, a[i, j, k]);
				}
                Console.WriteLine();	
			}
            Console.WriteLine();
		}
	}

}

