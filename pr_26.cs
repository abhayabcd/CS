using System;
class Jegged
{
    static void Main()
    {
        demo obj1 = new demo();
        obj1.column();
        obj1.assign();

        Console.WriteLine("\nJagged Array Elements:");
        foreach (int[] row in obj1.j)
        {
            foreach (int element in row)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
class abc
{
    public int[][] j;
    public void column()
    {
        j = new int[5][];
        j[0] = new int[5];
        j[1] = new int[1];
        j[2] = new int[3];
        j[3] = new int[1];
        j[4] = new int[5];
    }
}
class demo : abc
{
    int value=0;
    public void assign()
    {
        for (int i = 0; i < j.Length; i++)
        {
            for (int k = 0; k < j[i].Length; k++)
            {
                j[i][k] = value++;
                if (value > 9){
                    value = 0;
                }
            }
        }
    }
}