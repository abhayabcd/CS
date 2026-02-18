using System;
class demo
{
    public static void Main(String[] args)
    {
        abc obj1 = new abc(); 
        
    }
}
class abc
{
   public abc()
    {
        Console.WriteLine("Constructor called");
    }
    ~abc()
    {
        Console.WriteLine("Destructor called");
    }
}