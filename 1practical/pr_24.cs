using System;
class demo
{
    public static void Main(String[] args)
    {
        abc obj1 = new abc(); 
        obj1.b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Value of b in obj1: " + obj1.b);
    }
}
class abc
{
    public int b;
}