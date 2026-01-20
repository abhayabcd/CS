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

        // Input
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write("a[{0},{1}] = ", i, j);
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nElement Count:");

        // Counting logic
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (visited[i, j])
                    continue;

                int count = 0;

                for (int k = 0; k < r; k++)
                {
                    for (int l = 0; l < c; l++)
                    {
                        if (a[i, j] == a[k, l])
                        {
                            count++;
                            visited[k, l] = true;
                        }
                    }
                }
                if (count > 1)
                    Console.WriteLine("{0} occurs {1} times", a[i, j], count);
            }
        }
    }
}
