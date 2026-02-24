using System;
class Parent{
    protected void display(){
        Console.WriteLine("This is a protected method. in Parent class");
    }
}

class Child:Parent{
    public void show(){
        display();
        Console.WriteLine("Calling the protected method from Child class:");
    }
}

class subChild:Child{
    public void showAgain(){
        display();
        Console.WriteLine("Calling the protected method from subChild class:");
    }
}

class main{
    static void Main(){
        subChild c = new subChild();
        c.show();
        c.showAgain(); 
    }
}