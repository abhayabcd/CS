using System;
class statccon
{
    public static void Main(String[] args)
    {
        abc obj1 = new abc(); 
        abc obj2 = new abc();
    }
}
class abc
{
    int b;
    static abc()    {
        Console.WriteLine("Static constructor called");
    }
    public abc()    {
        Console.WriteLine("Instance constructor called");
    }
    public abc(abc obj)    {
        b = obj.b;
    }
    public void display()    {
        Console.WriteLine("Value of b: " + b);
    }
}