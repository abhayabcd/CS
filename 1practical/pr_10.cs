using System;
class boxing{
	static void Main(){
		int n=10;
		object a=n;
		Console.WriteLine(a);
		Console.WriteLine(n);
		a=10;
		n=(int)a;
		Console.WriteLine(a);
		Console.Write(n);
	}
}