using System;
class parameterized
{
    public parameterized(int x)
    {
        Console.WriteLine("This is a parameterized constructor. Value: " + x);
    }
}
class Program
{
    static void Main()
    {
        parameterized obj = new parameterized(10);
    }
}