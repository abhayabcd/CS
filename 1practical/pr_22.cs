using System;
class pr_22
{
    public static void Main(String[] args)
    {
        xyz obj1 = new xyz(10); 
        xyz obj2 = new xyz(20);
        xyz obj3 = new xyz(obj1,obj2);
        obj3.display(obj1,obj2);
    }
    }
class xyz
{
    int b;
    public xyz(int  a)    {
        b = a;
    }
    public xyz(xyz obj,xyz ob)    {
        b = obj.b + ob.b;
    }
    public void display(xyz obj,xyz ob){
        Console.Write("From obj3 Value of b {0} = {1}+{2}", b,obj.b, ob.b);
    }
}