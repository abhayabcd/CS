using System;
class parent
{
   public void print(){
        Console.WriteLine("This is Parent class");
    } 
}
class child1 : parent{
   public void display(){
        Console.WriteLine("This is Childe1 class");
    } 
}

class child2 : parent
{
     public void Show(){
        Console.Write("This is Childe2 class");
    } 
}
class main{
    static void Main(){
        child2 c = new child2();
        c.print();
        c.Show();
        child1 c1 = new child1();
        c1.print();
        c1.display();
    }
}