using System;
class looping{
    static void Main(){
        int[] arr={1,2,3,4,5};
        for(int i=0;i<5;i++){
            Console.WriteLine("for loop iteration: "+i);
            Console.WriteLine("Array element at index "+i+" is: "+arr[i]);
        }
        int j=0;
        while(j<5){
            Console.WriteLine("while loop iteration: "+j);
            Console.WriteLine("Array element at index "+j+" is: "+arr[j]);
            j++;
        }
        int k=0;
        do{
            Console.WriteLine("do-while loop iteration: "+k);
            Console.WriteLine("Array element at index "+k+" is: "+arr[k]);
            k++;
        }while(k<5);
        foreach(int num in arr){
            Console.WriteLine("foreach loop element: "+num);
        }
    }
}