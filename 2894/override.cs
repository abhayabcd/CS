using System;
class Base
{
    public virtual void Display()
    {
        Console.WriteLine("Base class method");
    }
}
class Derived : Base
{
    public override void Display()
    {
        Console.WriteLine("Derived class method");
    }
}
class Program
{
    static void Main()
    {
        Base obj = new Derived();
        obj.Display(); // Output: Derived class method
    }
}