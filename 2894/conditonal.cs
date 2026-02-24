using System;
class conditional{
    static void Main(){
        int a=10;
        int b=20;
        if(a>b){
            Console.WriteLine("a is greater than b");
            if(a>100){
                Console.WriteLine("a is greater than 100");
            }
        }
        else if(a<b){
            Console.WriteLine("a is less than b");
                if(a<5){
                    Console.WriteLine("a is less than 5");
                }
                else{
                    Console.WriteLine("a is greater than or equal to 5");
                }
        }
        else{
            Console.WriteLine("a is equal to b");
        }
    }
}