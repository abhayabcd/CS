using System;
class Parent{
    protected int a;
    public void show(){
        Console.WriteLine("Value of a is: "+a);
    }
}

class Child:Parent{
    public Child(){
        a=10;
    }
}

class main{
    static void Main(){
        Child c = new Child();
        c.show();
    } 
}