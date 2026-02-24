using System;
class default_constructor
{
    public default_constructor()
    {
        Console.WriteLine("This is a default constructor.");
    }
}
class Program
{
    static void Main()
    {
        default_constructor obj = new default_constructor();
    }
}