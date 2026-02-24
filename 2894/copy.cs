using System;
class copy
{
    public static void Main(String[] args)
    {
        xyz obj1 = new xyz(10); 
        xyz obj2 = new xyz(obj1);
        obj1.display();
        obj2.display();
       
    }
    }
class xyz
{
    int b;
    public xyz(int  a)    {
        b = a;
    }
    public xyz(xyz obj)    {
        b = obj.b;
    }
    public void display()    {
        Console.WriteLine("Value of b: " + b);
    }
}