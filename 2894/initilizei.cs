using System;
class demo
{
    public static void Main(String[] args)
    {
        xyz obj1 = new xyz(); 
        obj1.show();
        obj1.display();
    }
}
class abc
{
    public int x;
    public void display()
    {
        Console.WriteLine("Display method called "+x);
    }
}
class xyz : abc
{
    public void show()
    {
        x= 10;
        Console.WriteLine("Show method called");
    }
}