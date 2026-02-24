using System;
class paradatamem
{
    int data;
    public paradatamem(int value)
    {
        data = value;
    }
    public void Display()
    {
        Console.WriteLine("Data member value: " + data);
    }
}
class Program
{
    static void Main()
    {
        paradatamem obj = new paradatamem(42);
        obj.Display();
    }
}