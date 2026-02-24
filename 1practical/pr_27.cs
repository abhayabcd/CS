using System;

class Parent{
    protected int square(int x){
        return x*x;
    }
}

class Child : Parent{
    protected int getValue(int x){
        return square(x);
    }
} 

class subChild : Child{
    public int display(){
        Console.Write("Enter you number: ");
        return getValue(Convert.ToInt32(Console.ReadLine()));
    }
}

class main{
    static void Main(){
        subChild c = new subChild();
        Console.WriteLine("The square is: "+c.display());
    }
}
