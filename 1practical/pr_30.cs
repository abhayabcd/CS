using System;
class overloading
{
    public void print()
    {
        Console.WriteLine("This is Overloading class");
    }
    public void print(int x)
    {
        Console.WriteLine("This is Overloading class with int parameter: " + x);
    }
    public void print(double x)
    {
        Console.WriteLine("This is Overloading class with double parameter: " + x);
    }
    public void print(string x)
    {
        Console.WriteLine("This is Overloading class with string parameter: " + x);
    }
}
class main
{
    static void Main()
    {
        overloading o = new overloading();
        o.print();
        o.print(10);
        o.print(3.14);
        o.print("Hello");
    }
}