using System;
class demo
{
    public static void Main(String[] args)
    {
        xyz obj1 = new xyz(); 
        obj1.display();
        obj1.show();
    }
}
class abc
{
    public void display()
    {
        Console.WriteLine("Display method called");
    }
}
class xyz : abc
{
    public void show()
    {
        Console.WriteLine("Show method called");
    }
}