using System;
class demo
{
    public static void Main(String[] args)
    {
        abc obj1 = new abc(); 
        obj1.b = 10;
        obj1.display();
    }
}
class abc
{
    public int b;
    public void display()    {
        Console.WriteLine("Value of b: " + b);
    }
}