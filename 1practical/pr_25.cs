using System;
class Jegged
{
    static void Main()
    {
        demo obj1 = new demo();
        obj1.column();
        for (int i = 0; i < obj1.j.Length; i++)
        {
            for (int k = 0; k < obj1.j[i].Length; k++)
            {
                obj1.j[i][k] =1;
            }
            Console.WriteLine();
        }
        obj1.assign();
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

    public void assign()
    {
        for (int i = 0; i < j.Length; i++)
        {
            for (int k = 0; k < j[i].Length; k++)
            {
                Console.Write(j[i][k]+" ");
            }
            Console.WriteLine();
        }
    }
}