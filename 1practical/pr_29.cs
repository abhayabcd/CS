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

class subChild : child1
{
     public void message(){
        Console.WriteLine("This is subChild class");
    } 
}

class child2 : parent
{
     public void Show(){
        Console.WriteLine("This is Childe2 class");
    } 
}
class main{
    static void Main(){
        child2 c = new child2();
        c.print();
        c.Show();
        subChild c1 = new subChild();
        c1.print();
        c1.message();
    }
}