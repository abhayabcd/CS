using System;
class nStatic{
	public void fun(){
		Console.WriteLine("Hi");
	}
	static void Main(){
		nStatic s=new nStatic();
		s.fun();
	}
}